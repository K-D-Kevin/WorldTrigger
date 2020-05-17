using FPS.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockAgent : IAgent
{
    public Vector3 Position { get; set; }
    public Quaternion Rotation { get; set; }
    public Vector3 LocalPosition { get; set; }
    public Quaternion LocalRotation { get; set; }
    public Movement MaxMovementSpeed { get; set; }

    public float SprintMultiplier { get; }

    public Movement CurrentMovementSpeed { get; }

    public float MaxJumpForce { get; }

    public float CurrentJumpForce { get; }

    public float MaxSlowMultiplier { get; }

    public float MaxSpeedBuffMultiplier { get; }

    public float CurrentSlowMultiplier { get; }

    public float CurrentSpeedBuffMultiplier { get; }

    public Rotation MaxRotationSpeed { get; set; }

    public Rotation CurrentRotationSpeed { get; }

    public bool LocalMovement { get; }
}
