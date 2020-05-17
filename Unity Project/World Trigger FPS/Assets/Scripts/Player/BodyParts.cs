using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyParts : MonoBehaviour
{
    [SerializeField]
    private Transform LeftHandTransform;
    public Transform LeftHand { get { return LeftHandTransform; } }
    [SerializeField]
    private Transform RightHandTransform;
    public Transform RightHand { get { return RightHandTransform; } }
    [SerializeField]
    private Transform LeftItemHandTransform;
    public Transform LeftItem { get { return LeftItemHandTransform; } }
    [SerializeField]
    private Transform RightItemHandTransform;
    public Transform RightItem { get { return RightItemHandTransform; } }

    [SerializeField]
    private Transform HeadTransform;
    public Transform Head { get { return HeadTransform; } }
    [SerializeField]
    private Transform FeetTransform;
    public Transform Feet { get { return FeetTransform; } }
    [SerializeField]
    private Transform CameraTransform;
    public Transform Eyes { get { return CameraTransform; } }
    [SerializeField]
    private Camera FirstPersonCharacterCamera;
    public Camera FirstPersonCamera { get { return FirstPersonCharacterCamera; } }
    [SerializeField]
    private CameraController FirstPersonCharacterCameraController;
    public CameraController FirstPersonCameraControl { get { return FirstPersonCharacterCameraController; } }

    [SerializeField]
    private PlayerAnimationControl PlayerAnimationManager;
    public PlayerAnimationControl AnimationControl { get { return PlayerAnimationManager; } }

    [SerializeField]
    private MovementControls PlayerMovementController;
    public MovementControls PlayerMovementControls { get { return PlayerMovementController; } }

    [SerializeField]
    private Rigidbody PlayerRigibodyScript;
    public Rigidbody PlayerRigidbody { get { return PlayerRigibodyScript; } }

    [SerializeField]
    private TriggerHolder PlayerTriggerHolder;
    public TriggerHolder PlayerTrigger { get { return PlayerTriggerHolder; } }

    [SerializeField]
    private JumpCollider JumpHelper;
    public JumpCollider PlayerJumpHelper { get { return JumpHelper; } }
}
