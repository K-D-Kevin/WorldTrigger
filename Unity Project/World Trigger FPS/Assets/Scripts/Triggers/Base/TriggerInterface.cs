using FPS.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInterface : MonoBehaviour, ITrigger
{
    [SerializeField]
    protected float MaxHp;
    public float MaxHealth { get { return MaxHp; } }

    protected float CurrentHp;
    public float CurrentHealth { get { return CurrentHp; } }

    [SerializeField]
    protected float EquipCost;
    public float EquipTrionUsage { get { return EquipCost; } }

    [SerializeField]
    protected float ActiveCost;
    public float ActiveTrionUsage { get { return ActiveCost; } }

    [SerializeField]
    protected float RebuildCost;
    public float RebuildTrionUsage { get { return RebuildCost; } }

    [SerializeField]
    protected TriggerType TypeOfTrigger;
    public TriggerType Type { get { return TypeOfTrigger; } }

    [SerializeField]
    protected HoldType TypeOfHold;
    public HoldType Hold { get { return TypeOfHold; } }

    protected TriggerSide SideOfTrigger;
    public TriggerSide Side { get { return SideOfTrigger; } set { SideOfTrigger = value; } }

    [SerializeField]
    protected DamageState HealthState = DamageState.New;
    public DamageState StateOfDamage { get { return HealthState; } }

    public bool Equipped { get; internal set; }
    public bool Locked { get; internal set; }

    public float HealthRatio { get { return CurrentHp / MaxHp; } }

    protected virtual void Awake()
    {
        CurrentHp = MaxHp;
    }

    public virtual void Damage(float dmg)
    {
        if (HealthState != DamageState.Invulnerable)
        {
            CurrentHp -= dmg;
            if (HealthRatio > 0.8f)
            {
                HealthState = DamageState.Great;
            }
            else if (HealthRatio > 0.5f)
            {
                HealthState = DamageState.Good;
            }
            else if (HealthRatio > 0.25f)
            {
                HealthState = DamageState.Bad;
            }
            else if (HealthRatio > 0)
            {
                HealthState = DamageState.Terrible;
            }
            else
            {
                CurrentHp = 0;
                HealthState = DamageState.Broken;
                Equipped = false;
                Destroy();
            }
        }
    }

    public virtual float Build()
    {
        CurrentHp = MaxHp;
        HealthState = DamageState.New;
        return RebuildCost;
    }

    public virtual float Equip()
    {
        if (HealthState == DamageState.Broken || Locked)
        {
            DenyEquip();
            return 0;
        }
        else
        {
            Equipped = true;
            AcceptEquip();
            return EquipCost;
        }
    }

    protected virtual void DenyEquip()
    {

    }

    protected virtual void AcceptEquip()
    {

    }

    public virtual void Unequip()
    {
        Equipped = false;
    }

    public virtual void Destroy()
    {

    }

    public virtual void Lock()
    {
        Locked = true;
    }

    public virtual void Unlock()
    {
        Locked = false;
    }
}

namespace FPS.Enums
{
    public enum TriggerType
    {
        Attacker,
        Gunner,
        Sniper,
        Defense,
        Trap,
        Utility,
        Ammunition,
        Geist,
        Unnamed,
        Unknown,
    }

    public enum HoldType
    {
        Single, // Uses only one hand and can't be dual weld, but another weapon can be held in that hand
        Dual, // Can be held with one hand or two
        TwoHanded, // Requires both hands to use - Unequips the other single or dual wield weapons
        NoHanded, // Can be used when both hands are full
        Passive, // ActivAted automatically
    }

    public enum TriggerSide
    {
        Main,
        Sub,
    }

    public enum DamageState
    {
        New,
        Great,
        Good,
        Bad,
        Terrible,
        Broken,
        Invulnerable,
    }
}

