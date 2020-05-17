using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Enums;

public interface ITrigger
{
    float MaxHealth { get; }
    float CurrentHealth { get; }
    float ActiveTrionUsage { get; } // Cost to keep the weapon out (every second)
    float EquipTrionUsage { get; } // Cost to equip the trigger
    float RebuildTrionUsage { get; } // Cost to rebuild a broken trigger
    TriggerType Type {get;}
    HoldType Hold { get; }
    TriggerSide Side { get; }
    DamageState StateOfDamage { get; }
    bool Equipped { get; }
    bool Locked { get; }
}
