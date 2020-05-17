using FPS.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour, IAgent
{
    // Interface
    // Position
    protected AgentController Controls;
    public Vector3 Position { get { return transform.position; } set { transform.position = value; } }
    public Quaternion Rotation { get { return transform.rotation; } set { transform.rotation = value; } }
    public Vector3 LocalPosition { get { return transform.localPosition; } set { transform.localPosition = value; } }
    public Quaternion LocalRotation { get { return transform.localRotation; } set { transform.localRotation = value; } }

    // Movement
    [SerializeField]
    private bool UseLocal = true;
    public bool LocalMovement { get { return UseLocal; } set { UseLocal = value; } }

    [SerializeField]
    protected Movement MaxSpeed;
    public Movement MaxMovementSpeed { get { return MaxSpeed; } set { MaxSpeed = value; } }

    [SerializeField]
    protected float SprintIncrease = 1;
    public float SprintMultiplier { get { return SprintIncrease; } }

    public Movement CurrentMovementSpeed { get; set; }

    // Jump
    [SerializeField]
    protected float MaxJump = 1;
    public float MaxJumpForce { get { return MaxJump; } }

    public float CurrentJumpForce { get; internal set; }

    [SerializeField]
    protected float MaxSlow = 1;
    public float MaxSlowMultiplier { get { return MaxSlow; } }

    [SerializeField]
    protected float MaxSpeedBuff = 1;
    public float MaxSpeedBuffMultiplier { get { return MaxSpeedBuff; } }

    public float CurrentSlowMultiplier { get; }

    public float CurrentSpeedBuffMultiplier { get; }

    // Rotation
    [SerializeField]
    protected Rotation MaxRotation;
    public Rotation MaxRotationSpeed { get { return MaxRotation; } set { MaxRotation = value; } }

    public Rotation CurrentRotationSpeed { get; internal set; }

    protected virtual void Awake()
    {
        Controls = new AgentController(this);
        UpdateCurrentSpeed();
        UpdateRotationSpeed();
        UpdateJumpForce();
    }

    protected void UpdateCurrentSpeed()
    {
        CurrentMovementSpeed = MaxMovementSpeed / SprintIncrease / MaxSpeedBuff;
    }

    protected void UpdateRotationSpeed()
    {
        CurrentRotationSpeed = MaxRotationSpeed;
    }

    protected void UpdateJumpForce()
    {
        CurrentJumpForce = MaxJump;
    }

    protected virtual Vector3 Jump(Vector3 Direction)
    {
        return Direction;
    }
}
