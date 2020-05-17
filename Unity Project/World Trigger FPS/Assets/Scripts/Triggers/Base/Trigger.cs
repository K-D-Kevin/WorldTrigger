using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Enums;

public class Trigger : TriggerInterface
{
    // Base to all trigger objects

    public void SetSide(TriggerSide side)
    {
        SideOfTrigger = side;
    }
}
