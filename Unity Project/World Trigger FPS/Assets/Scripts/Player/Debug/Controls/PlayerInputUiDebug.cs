using FPS.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static FPS.Input.WorldTriggerInputs;

public class PlayerInputUiDebug : MonoBehaviour, IPlayerActions
{
    // Objects
    [SerializeField]
    private MoveAxisUiDebug MovementJoystick;
    [SerializeField]
    private MoveAxisUiDebug LookJoystick;
    [SerializeField]
    private ScrollViewEntry InputEntryPrefab;
    [SerializeField]
    private RectTransform EntrySpawn;
    private List<ScrollViewEntry> Entries = new List<ScrollViewEntry>();

    // Variables
    private WorldTriggerInputs PlayerInputs;
    private InputActionMap CurrentActionMap;

    private Vector2 MovementInput;
    public Vector2 MovementRatio { get { return MovementInput; } }
    private Vector2 LookInput;
    public Vector2 LookRatio { get { return LookInput; } }

    private void OnEnable()
    {
        PlayerInputs.Enable();
    }

    private void OnDisable()
    {
        PlayerInputs.Disable();
    }
    private void Awake()
    {
        PlayerInputs = new WorldTriggerInputs();
        PlayerInputs.Enable();
        PlayerInputs.Player.Move.performed += ctx => OnMove(ctx);
        PlayerInputs.Player.Look.performed += ctx => OnLook(ctx);
        PlayerInputs.Player.Melee.performed += ctx => OnMelee(ctx);
        PlayerInputs.Player.Jump.performed += ctx => OnJump(ctx);
        PlayerInputs.Player.LeanLeft.performed += ctx => OnLeanLeft(ctx);
        PlayerInputs.Player.LeanRight.performed += ctx => OnLeanRight(ctx);
        PlayerInputs.Player.Attach.performed += ctx => OnAttach(ctx);
        PlayerInputs.Player.Prone.performed += ctx => OnProne(ctx);
        PlayerInputs.Player.Crouch.performed += ctx => OnCrouch(ctx);
        PlayerInputs.Player.SwapToMainTriggerSlot1.performed += ctx => OnSwapToMainTriggerSlot1(ctx);
        PlayerInputs.Player.SwapToMainTriggerSlot2.performed += ctx => OnSwapToMainTriggerSlot2(ctx);
        PlayerInputs.Player.SwapToMainTriggerSlot3.performed += ctx => OnSwapToMainTriggerSlot3(ctx);
        PlayerInputs.Player.SwapToMainTriggerSlot4.performed += ctx => OnSwapToMainTriggerSlot4(ctx);
        PlayerInputs.Player.SwaptoSubTrigger1.performed += ctx => OnSwaptoSubTrigger1(ctx);
        PlayerInputs.Player.SwaptoSubTrigger2.performed += ctx => OnSwaptoSubTrigger2(ctx);
        PlayerInputs.Player.SwaptoSubTrigger3.performed += ctx => OnSwaptoSubTrigger3(ctx);
        PlayerInputs.Player.SwaptoSubTrigger4.performed += ctx => OnSwaptoSubTrigger4(ctx);
        PlayerInputs.Player.ToggleSwapRightMainTrigger.performed += ctx => OnToggleSwapRightMainTrigger(ctx);
        PlayerInputs.Player.ToggleSwapLeftMainTrigger.performed += ctx => OnToggleSwapLeftMainTrigger(ctx);
        PlayerInputs.Player.ToggleSwapRightSubTrigger.performed += ctx => OnToggleSwapRightSubTrigger(ctx);
        PlayerInputs.Player.ToggleSwapLeftSubTrigger.performed += ctx => OnToggleSwapLeftSubTrigger(ctx);
        PlayerInputs.Player.Info.performed += ctx => OnInfo(ctx);
        PlayerInputs.Player.Menu.performed += ctx => OnMenu(ctx);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //Debug.Log("Move: " + MovementInput);
        MovementInput = context.ReadValue<Vector2>();
        if (Entries.Count <= 0 || (Entries[Entries.Count - 1].EntryString != "Move " + context.control.path && MovementInput != Vector2.zero))
        {
            ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
            TempEntry.SetEntryText("Move " + context.control.path);
            TempEntry.transform.SetSiblingIndex(0);
            Entries.Add(TempEntry);
        }
        MovementJoystick.SetJoystickPosition(MovementInput);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        //Debug.Log("Look: " + LookInput);
        LookInput = context.ReadValue<Vector2>();
        if (Entries.Count <= 0 || (Entries[Entries.Count - 1].EntryString != "Look " + context.control.path && LookInput != Vector2.zero))
        {
            ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
            TempEntry.SetEntryText("Look " + context.control.path);
            TempEntry.transform.SetSiblingIndex(0);
            Entries.Add(TempEntry);
        }
        if (context.control.path == "/Mouse/delta")
        {
            LookJoystick.SetJoystickPosition(LookInput, true);
        }
        else
        {
            LookJoystick.SetJoystickPosition(LookInput);
        }
    }

    public void OnMelee(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Melee " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnReload(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Reload " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Jump " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnLeanLeft(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("LeanLeft " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnLeanRight(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("LeanRight " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnAttach(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Attach " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnProne(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Prone " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
        if (context.control.path == "/Keyboard/c" || context.control.path == "/Keyboard/n")
        {
            TempEntry.SetEntryText("Held To Prone " + context.control.path);
        }
        else
        {
            TempEntry.SetEntryText("Prone " + context.control.path);
        }
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Crouch " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwapToMainTriggerSlot1(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Main 1 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwapToMainTriggerSlot2(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Main 2 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwapToMainTriggerSlot3(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Main 3 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwapToMainTriggerSlot4(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Main 4 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnToggleSwapRightMainTrigger(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Toggle Swap Right Main " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnToggleSwapLeftMainTrigger(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Toggle Swap Left Main " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnToggleSwapRightSubTrigger(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Toggle Swap Right Sub " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnToggleSwapLeftSubTrigger(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Toggle Swap Left Sub " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwaptoSubTrigger1(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Sub 1 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwaptoSubTrigger2(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Sub 2 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwaptoSubTrigger3(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Sub 3 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSwaptoSubTrigger4(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Swap to Sub 4 " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnInfo(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Info " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnMenu(InputAction.CallbackContext context)
    {
        ScrollViewEntry TempEntry = Instantiate(InputEntryPrefab, EntrySpawn);
        TempEntry.SetEntryText("Menu " + context.control.path);
        TempEntry.transform.SetSiblingIndex(0);
        Entries.Add(TempEntry);
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        
    }
}
