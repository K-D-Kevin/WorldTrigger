using FPS.Enums;
using System;
using UnityEngine;
using GUIExtensions;

[CreateAssetMenu]
public class GunnerTriggerScriptableObject : ScriptableObject
{
    [Table] public GunnerTriggerInfo[] GunnerData;

    public GunnerTriggerInfo GetData(GunnerTriggerType Type, FireArmType FireArm)
    {
        foreach(GunnerTriggerInfo Info in GunnerData)
        {
            if (Info.GunnerType == Type && Info.FirearmType == FireArm)
            {
                return Info;
            }
        }
        return null;
    }
}

[Serializable]
public class GunnerTriggerInfo
{
    public GunnerTriggerType GunnerType;
    public AmmunitionType BaseBulletType;
    public FireArmType FirearmType;
    public float MinTrionUsage = 1;
    public float MaxTrionUsage = 2;
    public float MinChargeTime = 0.5f;
    public float MaxChargeTime = 0.5f;
    public float IntraClipReload = 0.5f; // ROF
    public float Reload = 3;
    public int ClipSize = 1;
    public int MinPellets = 1;
    public int MaxPellets = 16;
    public float MinBulletSpeed = 5;
    public float MaxBulletSpeed = 5;
    public float ExtremeRangeImpactDamage = 1;
    public float FarRangeImpactDamage = 1;
    public float MediumRangeImpactDamage = 1;
    public float CloseRangeImpactDamage = 1;
    public float FarRange = 1;
    public float MediumRange = 1;
    public float CloseRange = 1;
    public float ExplosiveDamage = 1;
    public float ExplosiveRange = 0;
    public ExplosiveDamageType ExplosionType;
}
