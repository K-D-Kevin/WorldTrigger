using FPS.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static FPS.Input.WorldTriggerInputs;

public class MovementControls : Agent, IPlayerActions
{
    // Parameters
    [SerializeField]
    private bool AnimationActive = true;

    // Objects
    [SerializeField]
    private BodyParts CharacterBodyParts;
    private PlayerAnimationControl AnimationControl;
    private CameraController CamControl;

    // Variables
    private WorldTriggerInputs PlayerInputs;

    private Vector2 MovementInput;
    public Vector2 MovementRatio { get { return MovementInput; } }
    private Vector2 LookInput;
    private int MouseInputCount = 0;
    public Vector2 LookRatio { get { return LookInput; } }
    public bool Sprinting { get; internal set; }
    private Vector3 MovementVector = new Vector3();
    public Vector3 MovementDirection { get { return MovementVector; } }
    public bool ControllerLooking { get; internal set; }
    public bool AnimationRunning { get { return AnimationActive; } set { AnimationActive = value; } }

    private void OnEnable()
    {
        PlayerInputs.Enable();
    }

    private void OnDisable()
    {
        PlayerInputs.Disable();
    }
    protected override void Awake()
    {
        base.Awake();
        AnimationControl = CharacterBodyParts.AnimationControl;
        CamControl = CharacterBodyParts.FirstPersonCameraControl;
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
        PlayerInputs.Player.Sprint.performed += ctx => OnSprint(ctx);
    }

    private void FixedUpdate()
    {
        Move();
        OnLookHandle();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
        if (AnimationActive)
            AnimationControl.UpdateMovementParameters(MovementInput);
        MovementVector.x = MovementInput.x;
        MovementVector.z = MovementInput.y;
    }

    public void Move()
    {
        MovementVector.x = MovementInput.x;
        MovementVector.z = MovementInput.y;
        float sprintmult;
        sprintmult = Sprinting ? SprintMultiplier : 1;
        float Length = MovementDirection.magnitude;
        MovementVector.x = MovementDirection.x / Length;
        MovementVector.z = MovementDirection.z * sprintmult / Length;
        CurrentMovementSpeed.Direction = MovementDirection;
        Controls.Move(CurrentMovementSpeed);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        if (context.control.path == "/Mouse/delta")
        {
            LookInput += context.ReadValue<Vector2>();
            MouseInputCount++;
            ControllerLooking = false;
        }
        else
        {
            LookInput = context.ReadValue<Vector2>();
            ControllerLooking = true;
        }
    }

    public void OnMelee(InputAction.CallbackContext context)
    {
        if (AnimationActive)
            AnimationControl.TriggerPunch();
    }

    protected override Vector3 Jump(Vector3 Direction)
    {
        //Debug.Log("Jumping");
        Vector3 Force = CurrentJumpForce * Direction * GameClock.DeltaTime / 0.2f;
        CharacterBodyParts.PlayerRigidbody.AddForce(Force, ForceMode.Impulse);

        //PreJumpVector = transform.forward;

        return Force;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (CharacterBodyParts.PlayerJumpHelper.CanJump)
        {
            if (!CharacterBodyParts.PlayerJumpHelper.Jumped)
            {
                // Jump
                CharacterBodyParts.PlayerJumpHelper.Jumped = true;
                Jump(transform.up);
            }
            else
            {
                if (!CharacterBodyParts.PlayerJumpHelper.DoubleJumped && CharacterBodyParts.PlayerJumpHelper.EnableDoubleJump)
                {
                    // Jump
                    CharacterBodyParts.PlayerJumpHelper.DoubleJumped = true;
                    Jump(transform.up);
                }
            }
        }
    }

    public void OnLeanLeft(InputAction.CallbackContext context)
    {
    }

    public void OnLeanRight(InputAction.CallbackContext context)
    {
    }

    public void OnAttach(InputAction.CallbackContext context)
    {
    }

    public void OnProne(InputAction.CallbackContext context)
    {
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
    }

    public void OnSwapToMainTriggerSlot1(InputAction.CallbackContext context)
    {
    }

    public void OnSwapToMainTriggerSlot2(InputAction.CallbackContext context)
    {
    }

    public void OnSwapToMainTriggerSlot3(InputAction.CallbackContext context)
    {
    }

    public void OnSwapToMainTriggerSlot4(InputAction.CallbackContext context)
    {
    }

    public void OnToggleSwapRightMainTrigger(InputAction.CallbackContext context)
    {
    }

    public void OnToggleSwapLeftMainTrigger(InputAction.CallbackContext context)
    {
    }

    public void OnToggleSwapRightSubTrigger(InputAction.CallbackContext context)
    {
    }

    public void OnToggleSwapLeftSubTrigger(InputAction.CallbackContext context)
    {
    }

    public void OnSwaptoSubTrigger1(InputAction.CallbackContext context)
    {
    }

    public void OnSwaptoSubTrigger2(InputAction.CallbackContext context)
    {
    }

    public void OnSwaptoSubTrigger3(InputAction.CallbackContext context)
    {
    }

    public void OnSwaptoSubTrigger4(InputAction.CallbackContext context)
    {
    }

    public void OnInfo(InputAction.CallbackContext context)
    {
    }

    public void OnMenu(InputAction.CallbackContext context)
    {
        
    }

    public void OnLookHandle()
    {
        if (ControllerLooking)
        {
            CamControl.ControllerMoveCamera(LookInput);
        }
        else
        {
            CamControl.MouseMoveCamera(LookInput);
            //Debug.Log("Mouse Inputs: " + MouseInputCount);
            LookInput = Vector2.zero;
            MouseInputCount = 0;
        }
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        Sprinting = !Sprinting;
        if (AnimationActive)
            AnimationControl.SetSprint(Sprinting);
    }
}
