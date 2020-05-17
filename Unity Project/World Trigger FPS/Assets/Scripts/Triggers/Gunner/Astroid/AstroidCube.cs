using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Enums;
using System;

public class AstroidCube : Agent
{
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
    private Vector3Int CubeIndex;
    public Vector3Int AstroidIndexPosition { get { return CubeIndex; } set { CubeIndex = value; } }
    private Astroid Trigger;
    [SerializeField]
    private List<Pathway> Pathways = new List<Pathway>();
    public Pathway DirectedPathway { get; internal set; }
    public Pathway ConstantPathway { get; internal set; }
    public Pathway OutwardPathway { get; internal set; }
    public Pathway WidePathway { get; internal set; }
    [SerializeField]
    private Explosion ExplosionObject;
    public Explosion Explosive { get { return ExplosionObject; } set { ExplosionObject = value; } }
    [SerializeField]
    private LayerMask ExplosionLayers;
    private List<int> Layers = new List<int>();
    public List<int> CollisionLayers { get { return Layers; } }
    [SerializeField]
    private GameObject ParentObject;

    // Variables
    private int CubeSize = 5;
    private int MaxCubeSize = 5;
    private float MaxInitialSpread = 5;
    public bool Travelling { get; internal set; }
    private float PathRatio = 0;
    public float TravelRatio { get { return PathRatio; } }
    private float CurrentPathDistance;
    public int CurrentPoint { get; internal set; }
    public bool AtReady { get; set; }
    public bool GoToReady { get; set; }
    public bool Fire { get; set; }

    public bool Wait { get; internal set; }
    private float WaitTimer = 0;
    private float WaitTime = 0;
    public Pathway SelectedPath { get; internal set; }
    private float PreviousPathRatio;
    public Vector3 Direction { get; internal set; }
    public Vector3 LastPosition { get; internal set; }

    private void OnValidate()
    {
        ExplosionObject = GetComponentInChildren<Explosion>();
    }

    protected override void Awake()
    {
        base.Awake();
        Initialized();
    }

    public void Initialized()
    {
        CurrentMovementSpeed.Direction = Vector3.zero;
        DirectedPathway = Pathways[0];
        ConstantPathway = Pathways[1];
        OutwardPathway = Pathways[2];
        WidePathway = Pathways[3];
        SelectedPath = DirectedPathway;
        CurrentPoint = 1;
        for (int i = 0; i < 32; i++)
        {
            if (((1 << i) & ExplosionLayers) != 0)
            {
                Layers.Add(i);
            }
        }
    }

    public void SetExplosiveParameters()
    {
        if (!ExplosionObject)
            ExplosionObject = GetComponentInChildren<Explosion>(includeInactive: true);
        if (ExplosionObject)
        {
            if (Trigger.Info == null)
            {
                Trigger.UpdateTriggerInfo();
            }
            ExplosionObject.Radius = Trigger.Info.ExplosiveRange;
            ExplosionObject.transform.localScale = Vector3.one * ExplosionObject.Radius * 10;
            ExplosionObject.DamageType = Trigger.Info.ExplosionType;
            ExplosionObject.Damage = Trigger.Info.ExplosiveDamage;
        }
    }
    public virtual void Initialize()
    {
        MaxMovementSpeed.Backward = Trigger.MaxBulletSpeed;
        MaxMovementSpeed.Forward = Trigger.MaxBulletSpeed;
        MaxMovementSpeed.Strafe = Trigger.MaxBulletSpeed;
        MaxMovementSpeed.Rise = Trigger.MaxBulletSpeed;
        MaxMovementSpeed.Fall = Trigger.MaxBulletSpeed;
        CurrentMovementSpeed = MaxMovementSpeed;
        gameObject.name = "Cube " + CubeIndex;
        SetExplosiveParameters();
    }

    public void SetPathwayParents()
    {
        DirectedPathway = Pathways[0];
        ConstantPathway = Pathways[1];
        OutwardPathway = Pathways[2];
        WidePathway = Pathways[3];
        DirectedPathway.SetPoints();
        ConstantPathway.SetPoints();
        OutwardPathway.SetPoints();
        WidePathway.SetPoints();
    }

    public void SetTrigger(Astroid trigger)
    {
        Trigger = trigger;
    }

    private void Update()
    {
        if (Wait)
        {
            Wait = WaitPoint();
        }
        else if (Travelling)
        {
            FollowPath();
        }
        else if (GoToReady)
        {
            if(TravelToPoint(2,SelectedPath))
            {
                GoToReady = false;
                AtReady = true;
            }
        }
        else if (Fire)
        {
            GoToReady = false;
            AtReady = false;
            Travelling = true;
        }
    }

    private bool WaitPoint()
    {
        CurrentMovementSpeed.Direction = Vector3.zero;
        WaitTimer += GameClock.DeltaTime;
        WaitTime = SelectedPath.Parameters[CurrentPoint].WaitTime;
        if (WaitTimer < WaitTime)
        {
            return true;
        }
        else
        {
            WaitTimer = 0;
            return false;
        }
    }

    private void FollowPath()
    {
        if (CurrentPoint + 1 < SelectedPath.PathPoints.Length)
        {
            Direction = SelectedPath.PathPoints[CurrentPoint + 1].position - SelectedPath.PathPoints[CurrentPoint].position;
            CurrentPathDistance = Direction.magnitude;
            CurrentMovementSpeed.Direction = Direction.normalized;
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        FollowPathway(SelectedPath);
    }

    private void FollowPathway(Pathway path)
    {
        if (CurrentPoint < path.PathPoints.Length)
        {
            if (TravelToPoint(CurrentPoint, path))
            {
                CurrentPoint++;
                Wait = true;
            }
        }
        else
        {
            Travelling = false;
            CurrentPoint = 2;
            CurrentMovementSpeed.Direction = Vector3.zero;
        }
    }

    private bool TravelToPoint(int Point, Pathway path)
    {
        CurrentPoint = Point;

        Controls.Move(CurrentMovementSpeed * SelectedPath.Parameters[CurrentPoint].SpeedRatio * GameClock.DeltaTime);
        Vector3 Distance = transform.position - LastPosition;
        PreviousPathRatio = PathRatio;
        PathRatio += Distance.magnitude / CurrentPathDistance;
        LastPosition = transform.position;
        if (PathRatio > 0.99)
        {
            PreviousPathRatio = 0;
            PathRatio = 0;

            return true;
        }
        return false;
    }

    public void GoToReadyPosition()
    {
        transform.position = DirectedPathway.PathPoints[2].position;
    }

    public void SetDraw(bool Set, bool DirectedOn = false, bool ConstantOn = false, bool OutwardOn = false, bool WideOn = false)
    {
        foreach (Pathway path in Pathways)
        {
            if (!Set)
            {
                path.SetDraw(false);
            }
            else
            {
                path.SetDraw(false);
                if (DirectedOn)
                {
                    if (path.PathwaySpread == SpreadMode.Directed)
                    {
                        path.SetDraw(true);
                    }
                }
                if (ConstantOn)
                {
                    if (path.PathwaySpread == SpreadMode.Constant)
                    {
                        path.SetDraw(true);
                    }
                }
                if (OutwardOn)
                {
                    if (path.PathwaySpread == SpreadMode.Outward)
                    {
                        path.SetDraw(true);
                    }
                }
                if (WideOn)
                {
                    if (path.PathwaySpread == SpreadMode.Wide)
                    {
                        path.SetDraw(true);
                    }
                }
            }
        }
    }

    public void UpdatePathing()
    {
        float HalfPoint = (float)(CubeSize) / 2;
        float MaxHalfPoint = (float)MaxCubeSize / 2;
        float MinRange = MaxHalfPoint - HalfPoint;
        float MaxRange = MaxCubeSize == CubeSize ? MaxHalfPoint + HalfPoint : MaxHalfPoint + HalfPoint - 0.5f;
        int LargestDirection = CubeIndex.x >= CubeIndex.y && CubeIndex.x >= CubeIndex.z ? CubeIndex.x : CubeIndex.y >= CubeIndex.x && CubeIndex.y >= CubeIndex.z ? CubeIndex.y : CubeIndex.z >= CubeIndex.x && CubeIndex.z >= CubeIndex.y ? CubeIndex.z : CubeIndex.z;
        int SmallestDirection = CubeIndex.x <= CubeIndex.y && CubeIndex.x <= CubeIndex.z ? CubeIndex.x : CubeIndex.y <= CubeIndex.x && CubeIndex.y <= CubeIndex.z ? CubeIndex.y : CubeIndex.z <= CubeIndex.x && CubeIndex.z <= CubeIndex.y ? CubeIndex.z : CubeIndex.z;
        gameObject.SetActive(true);
        SetPathwayParents();
        ReturnPathways();
        if (SmallestDirection < MinRange || LargestDirection > MaxRange)
        {
            gameObject.SetActive(false);
            //Debug.Log("Points - Max: " + MaxHalfPoint + ", Min: " + HalfPoint);
            //Debug.Log("Direction - Largest: " + LargestDirection + ", Smallest: " + SmallestDirection + " .Range - Min: " + MinRange + ", Max: " + MaxRange);
            // Debug.Log("Direction - Largest: " + LargestDirection + ", Smallest: " + SmallestDirection + " .Range - Min: " + MinRange + ", Max: " + MaxRange + ", Index: " + CubeIndex);
        }
        else
        {
            SetInitialPosition();
            UpdateDirectedPathing();
            UpdateWidePathing();
            UpdateOutwardPathing();
            UpdateStraightPathing();
            //Debug.Log("Turn On and Pathfind");
        }
    }

    public void UpdatePathing(float directedRange, float wideSpread, float outwardSpread, int Size, int MaxSize, float initialSpread)
    {
        DirectedRange = directedRange;
        WideSpread = wideSpread;
        OutwardSpread = outwardSpread;
        CubeSize = Size;
        MaxCubeSize = MaxSize >= CubeSize ? MaxSize : CubeSize;
        InitialSpread = initialSpread;
        UpdatePathing();
    }

    public void SetInitialPosition()
    {
        transform.localPosition = (Vector3)CubeIndex * 0.1f;
    }

    private void UpdateDirectedPathing()
    {
        // Start Position
        DirectedPathway.PathPoints[1].localPosition = Vector3.zero;
        DirectedPathway.PathPoints[1].name = "Start Position";

        // Ready Position
        float MidNum = Mathf.Ceil((float)Trigger.AstroidSize / 2);
        Vector3 ReadyPosition = new Vector3(MidNum - CubeIndex.z, CubeIndex.y - MidNum, CubeIndex.x - MidNum) * 0.01f;
        DirectedPathway.PathPoints[2].localPosition = ReadyPosition;
        DirectedPathway.PathPoints[2].name = "Ready Position";

        // Initial Bloom Position
        float ForwardOffset = InitialSpread / 10;
        Vector3 InitialBloomPosition = ReadyPosition.normalized * InitialSpread  / (2 * Trigger.AstroidSize) + Vector3.forward * ForwardOffset;
        DirectedPathway.PathPoints[3].localPosition = InitialBloomPosition;
        DirectedPathway.PathPoints[3].name = "Initial Spread Position";

        // Outward Direction
        DirectedPathway.PathPoints[4].localPosition = Vector3.forward * DirectedRange;
        DirectedPathway.PathPoints[4].name = "End Position";
    }
    private void UpdateStraightPathing()
    {
        // Start Position
        ConstantPathway.PathPoints[1].localPosition = Vector3.zero;
        ConstantPathway.PathPoints[1].name = "Start Position";

        // Ready Position
        float MidNum = Mathf.Ceil((float)Trigger.AstroidSize / 2);
        Vector3 ReadyPosition = new Vector3(MidNum - CubeIndex.z, CubeIndex.y - MidNum, CubeIndex.x - MidNum) * 0.01f;
        ConstantPathway.PathPoints[2].localPosition = ReadyPosition;
        ConstantPathway.PathPoints[2].name = "Ready Position";

        // Initial Bloom Position
        float ForwardOffset = InitialSpread / 10;
        Vector3 InitialBloomPosition = ReadyPosition.normalized * InitialSpread / (2 * Trigger.AstroidSize) + Vector3.forward * ForwardOffset;
        ConstantPathway.PathPoints[3].localPosition = InitialBloomPosition;
        ConstantPathway.PathPoints[3].name = "Initial Spread Position";

        // Outward Direction
        ConstantPathway.PathPoints[4].localPosition = ConstantPathway.PathPoints[3].localPosition + Vector3.forward * DirectedRange;
        ConstantPathway.PathPoints[4].name = "End Position";
    }
    private void UpdateOutwardPathing()
    {
        // Start Position
        OutwardPathway.PathPoints[1].localPosition = Vector3.zero;
        OutwardPathway.PathPoints[1].name = "Start Position";

        // Ready Position
        float MidNum = Mathf.Ceil((float)Trigger.AstroidSize / 2);
        Vector3 ReadyPosition = new Vector3(MidNum - CubeIndex.z, CubeIndex.y - MidNum, CubeIndex.x - MidNum) * 0.01f;
        OutwardPathway.PathPoints[2].localPosition = ReadyPosition;
        OutwardPathway.PathPoints[2].name = "Ready Position";
        Vector3 ReadyPositionNormal = ReadyPosition.normalized;

        // Initial Bloom Position
        float ForwardOffset = InitialSpread / 10;
        Vector3 InitialBloomPosition = ReadyPosition.normalized * InitialSpread / (2 * Trigger.AstroidSize) + Vector3.forward * ForwardOffset;
        OutwardPathway.PathPoints[3].localPosition = InitialBloomPosition;
        OutwardPathway.PathPoints[3].name = "Initial Spread Position";

        // Outward Direction
        Vector3 FinalBloomPosition = new Vector3(ReadyPositionNormal.x * CubeIndex.x, ReadyPositionNormal.y * CubeIndex.y, ReadyPositionNormal.z * CubeIndex.z) / Trigger.AstroidSize + Vector3.forward * DirectedRange;
        OutwardPathway.PathPoints[4].localPosition = ReadyPosition.normalized * OutwardSpread + OutwardPathway.PathPoints[3].localPosition + FinalBloomPosition + Vector3.forward * DirectedRange;
        OutwardPathway.PathPoints[4].name = "End Position";
    }
    private void UpdateWidePathing()
    {
        // Start Position
        WidePathway.PathPoints[1].localPosition = Vector3.zero;
        WidePathway.PathPoints[1].name = "Start Position";

        // Ready Position
        float MidNum = Mathf.Ceil((float)Trigger.AstroidSize / 2);
        Vector3 ReadyPosition = new Vector3(MidNum - CubeIndex.z, CubeIndex.y - MidNum, CubeIndex.x - MidNum) * 0.01f;
        WidePathway.PathPoints[2].localPosition = ReadyPosition;
        WidePathway.PathPoints[2].name = "Ready Position";
        Vector3 ReadyPositionNormal = ReadyPosition.normalized;

        // Initial Bloom Position
        float ForwardOffset = InitialSpread / 10;
        Vector3 InitialBloomPosition = ReadyPosition.normalized * InitialSpread / (2 * Trigger.AstroidSize) + Vector3.forward * ForwardOffset;
        WidePathway.PathPoints[3].localPosition = InitialBloomPosition;
        WidePathway.PathPoints[3].name = "Initial Spread Position";

        // Outward Direction
        Vector3 FinalBloomPosition = new Vector3(ReadyPositionNormal.x * CubeIndex.x, ReadyPositionNormal.y * CubeIndex.y, ReadyPositionNormal.z * CubeIndex.z) / Trigger.AstroidSize + Vector3.forward * DirectedRange;
        WidePathway.PathPoints[4].localPosition = ReadyPosition.normalized * WideSpread + WidePathway.PathPoints[3].localPosition + FinalBloomPosition + Vector3.forward * DirectedRange;
        WidePathway.PathPoints[4].name = "End Position";
    }

    public void ReturnPathways()
    {
        foreach(Pathway path in Pathways)
        {
            path.transform.SetParent(transform);
            path.transform.localPosition = Vector3.zero;
            path.transform.localScale = Vector3.one / 0.1f;
            //Debug.Log("Set Transform");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Layers.Contains(collision.gameObject.layer))
        {
            if (collision.gameObject != Trigger.gameObject)
            {
                Explosive.enabled = true;
                Explosive.ExplosionHit = collision.contacts[0].point;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Layers.Contains(other.gameObject.layer))
        {
            if (other.gameObject != Trigger.gameObject)
            {
                Explosive.enabled = true;
                Explosive.ExplosionHit = other.ClosestPoint(Explosive.transform.position);
            }
        }
    }

    public void DestroyCube()
    {
        Destroy(ParentObject);
    }

    public void DestroyCubeNow()
    {
        DestroyImmediate(ParentObject);
    }
}

[Serializable]
public class PointSpeedParameters
{
    public int Point;
    public float SpeedRatio;
    public float WaitTime;
}
