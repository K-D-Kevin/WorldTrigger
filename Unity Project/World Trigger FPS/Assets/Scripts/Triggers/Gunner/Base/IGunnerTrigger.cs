using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Enums;

public interface IGunnerTrigger
{
    GunnerTriggerType GunnerType {get;}
    FireArmType FireArm { get; }
    AmmunitionType BaseAmmunition { get; }
    // Variables
    bool Charging { get; }
    bool Charged { get; }
    bool FullCharge { get;}
    bool InMotion { get; }

    // Infomation Variables
    float MaxChargeTime { get; }
    float MinChargeTime { get;}
    float ChargeTimer { get;  }

    int CurrentRound { get; }
    int ClipSize { get;}
    int MaxPellets { get; }
    int MinPellets { get; }

    float ReloadTime { get; }
    float IntraClipReload { get; }
    float ReloadTimer { get; }

    float FarRange { get; }
    float MediumRange { get; }
    float CloseRange { get; }
    float ExplosiveRange { get; }

    float ExtremeRangeDamage { get; }
    float FarRangeDamage { get;  }
    float MediumRangeDamage { get;}
    float CloseRangeDamage { get;}
    float ExplosionDamage { get;}

    float CurrentRange { get;}
    ExplosiveDamageType ExplosiveType { get;}
    float MaxBulletSpeed { get; }
    float CurrentBulletSpeed { get;}
    float MinBulletSpeed { get; }

    float MaxTrionUse { get;}
    float CurrentTrionUse { get;}
    float MinTrionUse { get;}
}
