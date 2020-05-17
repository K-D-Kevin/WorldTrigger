using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS.Game
{
    public interface IAgent
    {
        // Position
        Vector3 Position { get; set; }
        Quaternion Rotation { get; set;}
        Vector3 LocalPosition { get; set; }
        Quaternion LocalRotation { get; set; }

        // Movement
        // Maximum
        bool LocalMovement { get; }
        Movement MaxMovementSpeed { get; set; }
        float SprintMultiplier { get; }
        // Current
        Movement CurrentMovementSpeed { get;}

        // Jumping
        // Maximum
        float MaxJumpForce { get; }
        // Current
        float CurrentJumpForce { get; }

        // Buffs
        // Maximum
        float MaxSlowMultiplier { get; }
        float MaxSpeedBuffMultiplier { get; }
        // Current
        float CurrentSlowMultiplier { get; }
        float CurrentSpeedBuffMultiplier { get; }

        // Rotation
        Rotation MaxRotationSpeed { get; set; }

        Rotation CurrentRotationSpeed { get; }

    }
}
