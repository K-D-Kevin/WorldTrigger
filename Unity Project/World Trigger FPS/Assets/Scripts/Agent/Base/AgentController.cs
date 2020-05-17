using FPS.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController
{
    private IAgent ThisAgent;

    public AgentController(IAgent agent)
    {
        ThisAgent = agent;
    }

    public void Move(Vector3 Displacement)
    {
        if (ThisAgent.LocalMovement)
        {
            Vector3 direction = Quaternion.Euler(ThisAgent.Rotation.eulerAngles) * Displacement;
            direction.x = float.IsNaN(direction.x) ? 0 : direction.x;
            direction.y = float.IsNaN(direction.y) ? 0 : direction.y;
            direction.z = float.IsNaN(direction.z) ? 0 : direction.z;
            ThisAgent.Position += direction * GameClock.DeltaTime;
        }
        else
        {
            ThisAgent.Position += Displacement* GameClock.DeltaTime;
        }
    }

    public void Move(Movement Displacement)
    {
        if (ThisAgent.LocalMovement)
        {
            Vector3 direction = Quaternion.Euler(ThisAgent.Rotation.eulerAngles) * Displacement;
            direction.x = float.IsNaN(direction.x) ? 0 : direction.x;
            direction.y = float.IsNaN(direction.y) ? 0 : direction.y;
            direction.z = float.IsNaN(direction.z) ? 0 : direction.z;
            ThisAgent.Position += direction * GameClock.DeltaTime;
        }
        else
        {
            ThisAgent.Position += Displacement * GameClock.DeltaTime;
        }
    }

    public void Move(Vector3 Displacement, Transform Direction)
    {
        if (ThisAgent.LocalMovement)
        {
            ThisAgent.Position += Quaternion.Euler(Direction.rotation.eulerAngles) * Displacement;
        }
        else
        {
            ThisAgent.Position += Displacement;
        }
    }

    public void Move(Movement Displacement, Transform Direction)
    {
        if (ThisAgent.LocalMovement)
        {
            ThisAgent.Position += Quaternion.Euler(Direction.rotation.eulerAngles) * Displacement;
        }
        else
        {
            ThisAgent.Position += Displacement;
        }
    }

    public void Rotate(Quaternion rotate)
    {
        ThisAgent.Rotation = Quaternion.Euler(ThisAgent.Rotation.eulerAngles.x + rotate.eulerAngles.x, ThisAgent.Rotation.eulerAngles.y + rotate.eulerAngles.y, ThisAgent.Rotation.eulerAngles.z + rotate.eulerAngles.z);
    }

    public void Rotate(Rotation rotate)
    {
        ThisAgent.Rotation += rotate;
    }
}
