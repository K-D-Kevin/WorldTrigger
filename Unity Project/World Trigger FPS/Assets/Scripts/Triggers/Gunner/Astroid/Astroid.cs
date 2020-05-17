using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Enums;
using UnityEngine.InputSystem;
using static FPS.Input.WorldTriggerInputs;
using FPS.Input;

public class Astroid : GunnerTrigger, IAstroidActions
{
    #region Parameters / Objects / Variables
    [SerializeField]
    private GameObject CubePrefab;
    private List<AstroidCube> Cubes = new List<AstroidCube>();
    private List<AstroidCube> ActiveCubes = new List<AstroidCube>();

    [SerializeField]
    private SpreadMode StartSpreadMode;
    public SpreadMode CurrentSpreadMode { get; internal set; }

    [SerializeField]
    private Transform PathwayTransformParent;
    public Transform PathwayParent { get { return PathwayTransformParent; } }
    [SerializeField]
    private Transform CubesTransformParent;
    public Transform CubeParent { get { return CubesTransformParent; } }

    [SerializeField]
    private float DirectedRange = 10;
    public float DirectionDistance { get { return DirectedRange; } set { DirectedRange = value; } }
    [SerializeField]
    private float WideSpread = 10;
    public float WideMaxSpread { get { return WideSpread; } set { WideSpread = value; } }
    [SerializeField]
    private float OutwardSpread = 10;
    public float OutwardMaxSpread { get { return OutwardSpread; } set { OutwardSpread = value; } }
    [SerializeField]
    private float InitialSpread = 10;
    public float InitialMaxSpread { get { return InitialSpread; } set { InitialSpread = value; } }
    [SerializeField]
    private int CubeSize = 5;
    public int AstroidSize { get { return CubeSize; } set { CubeSize = value; } }
    [SerializeField]
    private int MaxCubeSize = 5;
    public int MaxAstroidSize { get { return MaxCubeSize; } set { MaxCubeSize = value; } }
    public Agent Player = null;
    public Agent TriggerHolder { get { return Player; } set { Player = value; } }

    [SerializeField]
    private bool DrawPathways = false;
    [SerializeField]
    private bool DrawDirectedPathways = false;
    [SerializeField]
    private bool DrawConstantPathways = false;
    [SerializeField]
    private bool DrawOutwardPathways = false;
    [SerializeField]
    private bool DrawWidePathways = false;

    // Variables
    private WorldTriggerInputs PlayerInputs;
    #endregion

    #region Initialization
    protected override void Awake()
    {
        base.Awake();
        CurrentSpreadMode = StartSpreadMode;
        SetCubes();
    }
    protected override void Start()
    {
        base.Start();
        InitializeCubes();
        UpdateActiveCubes();
    }
    private void OnEnable()
    {
        if (PlayerInputs != null)
            PlayerInputs.Enable();
    }
    private void OnDisable()
    {
        if (PlayerInputs != null)
            PlayerInputs.Disable();
    }
    public void InitializeAstroid(TriggerSide side)
    {
        Side = side;
        PlayerInputs = new WorldTriggerInputs();
        PlayerInputs.Disable();
        if (Side == TriggerSide.Main)
        {
            PlayerInputs.Astroid.AstroidCancelMainTrigger.performed += ctx => OnAstroidCancelMainTrigger(ctx);
            PlayerInputs.Astroid.AstroidChargeMainTrigger.performed += ctx => OnAstroidChargeMainTrigger(ctx);
            PlayerInputs.Astroid.AstroidFireMainTrigger.performed += ctx => OnAstroidFireMainTrigger(ctx);
        }
        else
        {
            PlayerInputs.Astroid.AstroidCancelSubTrigger.performed += ctx => OnAstroidCancelSubTrigger(ctx);
            PlayerInputs.Astroid.AstroidChargeMainTrigger.performed += ctx => OnAstroidChargeSubTrigger(ctx);
            PlayerInputs.Astroid.AstroidFireMainTrigger.performed += ctx => OnAstroidFireSubTrigger(ctx);
        }
        PlayerInputs.Astroid.Reload.performed += ctx => OnReload(ctx);
    }
    private void InitializeCubes()
    {
        foreach (AstroidCube cube in Cubes)
        {
            cube.Initialize();
        }
    }
    #endregion

    #region Debug / Helpers
    public void OnDrawGizmos()
    {
        if (DrawPathways)
        {
            SetCubes();
            foreach (AstroidCube cube in Cubes)
            {
                cube.SetDraw(DrawPathways, DrawDirectedPathways, DrawConstantPathways, DrawOutwardPathways, DrawWidePathways);
            }
        }
    }
    public void CreateNewAstroid()
    {
        AstroidCube[] CubesArr = CubeParent.GetComponentsInChildren<AstroidCube>(includeInactive: true);
        foreach (AstroidCube cube in CubesArr)
        {
            cube.ReturnPathways();
            cube.DestroyCubeNow();
        }

        for (int x = 1; x <= MaxCubeSize; x++)
        {
            for (int y = 1; y <= MaxCubeSize; y++)
            {
                for (int z = 1; z <= MaxCubeSize; z++)
                {
                    AstroidCube NewCube = Instantiate(CubePrefab, CubeParent).GetComponentInChildren<AstroidCube>();
                    NewCube.AstroidIndexPosition = new Vector3Int(x, y, z);
                    NewCube.SetInitialPosition();
                }
            }
        }
    }
    public void ReturnPathways()
    {
        SetCubes();
        InitializeCubes();
        foreach (AstroidCube Cube in Cubes)
        {
            if (!Cube.gameObject.activeSelf)
            {
                //Debug.Log("Turn Cube Back On");
                Cube.gameObject.SetActive(true);
            }
            Cube.ReturnPathways();
        }
    }
    #endregion

    #region Control
    public void ToggleSpreadMode()
    {
        int NextSpreadMode = (int)CurrentSpreadMode++;
        NextSpreadMode = NextSpreadMode > 4 ? 0 : NextSpreadMode;
        SetSpreadMode((SpreadMode)NextSpreadMode);
    }

    public void SetSpreadMode(SpreadMode Mode)
    {
        CurrentSpreadMode = Mode;
    }

    public void UpdateTriggerInfo()
    {
        TriggerInfo = DataManager.GetGunnerTriggerInfo(TypeOfGunner, TypeOfFireArm);
    }
    public override void Fire()
    {
        foreach(AstroidCube cube in ActiveCubes)
        {
            cube.Fire = true;
        }
    }

    public void SetCubes()
    {
        if (Cubes.Count > 0)
        {
            Cubes.Clear();
        }
        foreach (AstroidCube cube in GetComponentsInChildren<AstroidCube>(includeInactive:true))
        {
            if (!Cubes.Contains(cube))
            {
                cube.SetTrigger(this);
                cube.SetPathwayParents();
                cube.Initialize();
                Cubes.Add(cube);
            }
        }
    }

    public void UpdateActiveCubes()
    {
        if (ActiveCubes.Count > 0)
        {
            ActiveCubes.Clear();
        }
        foreach (AstroidCube cube in GetComponentsInChildren<AstroidCube>(includeInactive: false))
        {
            if (!ActiveCubes.Contains(cube))
            {
                cube.SetTrigger(this);
                cube.SetPathwayParents();
                ActiveCubes.Add(cube);
            }
        }
    }

    public void UpdateCubes()
    {
        SetCubes();
        InitializeCubes();
        //Debug.Log("Cubes: " + Cubes.Count);
        foreach (AstroidCube Cube in Cubes)
        {
            if (!Cube.gameObject.activeSelf)
            {
                //Debug.Log("Turn Cube Back On");
                Cube.gameObject.SetActive(true);
            }
            Cube.UpdatePathing(DirectedRange, WideSpread, OutwardSpread, CubeSize, MaxCubeSize, InitialSpread);
        }
        UpdateActiveCubes();
    }

    public void OnAstroidChargeMainTrigger(InputAction.CallbackContext context)
    {
        
    }

    public void OnAstroidFireMainTrigger(InputAction.CallbackContext context)
    {
        Fire();
    }

    public void OnAstroidChargeSubTrigger(InputAction.CallbackContext context)
    {
        
    }

    public void OnAstroidFireSubTrigger(InputAction.CallbackContext context)
    {
        Fire();
    }

    public void OnAstroidCancelMainTrigger(InputAction.CallbackContext context)
    {
       
    }

    public void OnAstroidCancelSubTrigger(InputAction.CallbackContext context)
    {
        
    }

    public void OnReload(InputAction.CallbackContext context)
    {
        
    }
    #endregion
}

namespace FPS.Enums
{
    public enum SpreadMode
    {
        Directed, // All Head Towards a point
        Constant, // All Head at the same spread
        Outward, // All Head outwards in a slight spread pattern
        Wide, // All Head outwords in a wide spread pattern
    }
}
