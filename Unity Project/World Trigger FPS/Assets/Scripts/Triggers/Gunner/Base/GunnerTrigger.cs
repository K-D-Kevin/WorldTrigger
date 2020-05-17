using FPS.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerTrigger : Trigger, IGunnerTrigger
{
    [SerializeField]
    protected GunnerTriggerType TypeOfGunner;
    public GunnerTriggerType GunnerType { get {return TypeOfGunner;}}

    [SerializeField]
    protected FireArmType TypeOfFireArm;
    public FireArmType FireArm { get { return TypeOfFireArm; } }

    [SerializeField]
    protected AmmunitionType TypeOfAmmunition;
    public AmmunitionType BaseAmmunition { get { return TypeOfAmmunition; } }

    protected GunnerTriggerInfo TriggerInfo;
    public GunnerTriggerInfo Info { get { return TriggerInfo; } }

    // Variables
    public bool Charging { get; internal set;  }
    public bool Charged { get; internal set; }
    public bool FullCharge { get; internal set; }
    public bool InMotion { get; internal set; }

    // Infomation Variables
    public float MaxChargeTime { get; internal set; }
    public float MinChargeTime { get; internal set; }
    public float ChargeTimer { get; internal set; }

    public int CurrentRound { get; internal set; }
    public int ClipSize { get; internal set; }
    public int MaxPellets { get; internal set; }
    public int MinPellets { get; internal set; }

    public float ReloadTime { get; internal set; }
    public float IntraClipReload { get; internal set; }
    public float ReloadTimer { get; internal set; }

    public float FarRange { get; internal set; }
    public float MediumRange { get; internal set; }
    public float CloseRange { get; internal set; }
    public float ExplosiveRange { get; internal set; }

    public float ExtremeRangeDamage { get; internal set; }
    public float FarRangeDamage { get; internal set; }
    public float MediumRangeDamage { get; internal set; }
    public float CloseRangeDamage { get; internal set; }
    public float ExplosionDamage { get; internal set; }

    public float CurrentRange { get; internal set; }
    public ExplosiveDamageType ExplosiveType { get; internal set; }
    public float MaxBulletSpeed { get; internal set; }
    public float CurrentBulletSpeed { get; internal set; }
    public float MinBulletSpeed { get; internal set; }

    public float MaxTrionUse { get; internal set; }
    public float CurrentTrionUse { get; internal set; }
    public float MinTrionUse { get; internal set; }

    protected override void Awake()
    {
        base.Awake();
        TriggerInfo = DataManager.GetGunnerTriggerInfo(TypeOfGunner, TypeOfFireArm);
    }

    protected virtual void Start()
    {

        // Initialize Info
        // Charging
        MaxChargeTime = TriggerInfo.MaxChargeTime;
        MinChargeTime = TriggerInfo.MinChargeTime;

        // Clip
        ClipSize = TriggerInfo.ClipSize;
        CurrentRound = ClipSize;
        ReloadTime = TriggerInfo.Reload;
        IntraClipReload = TriggerInfo.IntraClipReload;
        MinPellets = TriggerInfo.MinPellets;
        MaxPellets = TriggerInfo.MaxPellets;

        // Range
        FarRange = TriggerInfo.FarRange;
        MediumRange = TriggerInfo.MediumRange;
        CloseRange = TriggerInfo.CloseRange;
        ExplosiveRange = TriggerInfo.ExplosiveRange;
        CurrentRange = 0;

        // Damage
        ExtremeRangeDamage = TriggerInfo.ExtremeRangeImpactDamage;
        FarRangeDamage = TriggerInfo.FarRangeImpactDamage;
        MediumRange = TriggerInfo.MediumRangeImpactDamage;
        CloseRangeDamage = TriggerInfo.CloseRangeImpactDamage;
        ExplosionDamage = TriggerInfo.ExplosiveDamage;
        ExplosiveType = TriggerInfo.ExplosionType;

        // Bullet Speed
        MaxBulletSpeed = TriggerInfo.MaxBulletSpeed;
        MinBulletSpeed = TriggerInfo.MinBulletSpeed;
        CurrentBulletSpeed = 0;

        // Trion
        MaxTrionUse = TriggerInfo.MaxTrionUsage;
        MinTrionUse = TriggerInfo.MinTrionUsage;
        CurrentTrionUse = 0;
    }

    protected virtual IEnumerator IE_Charge()
    {
        ChargingStart();
        while (Charging)
        {
            ChargingUpdate();
            yield return null;
        }
        ChargingComplete();
    }

    protected virtual void StartCharging()
    {
        if (!Locked)
        {
            ChargeTimer = 0;
            Charging = true;
            Charged = false;
            StartCoroutine(IE_Charge());
        }
    }
    protected virtual void ChargingUpdate()
    {
        if (ChargeTimer > MaxChargeTime)
        {
            ChargeTimer = MaxChargeTime;
        }
        else if (ChargeTimer < MaxChargeTime)
        {
            ChargeTimer += GameClock.DeltaTime;
        }
        else
        {
            FullCharge = true;
        }
    }
    protected virtual void ChargingStart()
    {

    }

    protected virtual void ChargingComplete()
    {

    }
    protected virtual float EndCharging()
    {
        if (ChargeTimer > MinChargeTime)
        {
            Charging = false;
            float OldTimer = ChargeTimer;
            ChargeTimer = 0;
            Charged = true;
            return OldTimer;
        }
        else
        {
            Charging = false;
            ChargeTimer = 0;
            Charged = false;
            return ChargeTimer;
        }
    }

    public virtual void Fire()
    {
        if (Charged)
        {
            FullCharge = false;
            InMotion = true;
            StartCoroutine(FireTrigger());
        }
    }

    protected virtual IEnumerator FireTrigger()
    {
        FireStart();
        while (InMotion)
        {
            FireUpdate();
            yield return null;
        }
        FireComplete();
    }

    protected virtual void FireUpdate()
    {

    }

    protected virtual void FireStart()
    {

    }

    protected virtual void FireComplete()
    {

    }

    public void SetAmmunitionType(AmmunitionType Ammo)
    {
        TypeOfAmmunition = Ammo;
    }

    protected virtual void Reload()
    {
        StartCoroutine(IE_Reload());
    }

    protected virtual IEnumerator IE_Reload()
    {
        ReloadTimer = 0;
        ReloadStart();
        while (ReloadTimer < ReloadTime)
        {
            ReloadUpdate();
            yield return null;
        }
        ReloadComplete();
        CurrentRound = ClipSize;
        ReloadTimer = 0;
    }

    protected virtual void ReloadStart()
    {

    }

    protected virtual void ReloadUpdate()
    {
        ReloadTimer += GameClock.DeltaTime;
    }

    protected virtual void ReloadComplete()
    {

    }
}

namespace FPS.Enums
{
    public enum GunnerTriggerType
    {
        Astroid,
        Firearm,
        Hound,
        Meteor,
        Viper,
        FullArms,
        Cobra,
        Gimlet,
        Hornet,
        Salamander,
        Tomahawk,
    }

    public enum AmmunitionType
    {
        Trion, // Astroid - Used Trion to avoid confusion
        Lead,
        Bullet,
        Grenade,
        Other,
    }

    public enum FireArmType
    {
        None, // Trion gunner triggers
        AssualtRifleVar1,
        GrenadeLauncher,
        Pistol,
        Minigun,
        Shotgun,
        Sniper,
    }

    public enum ExplosiveDamageType
    {
        Fixed,
        Scale,
        InverseScale,
    }
}
