using FPS.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField]
    private GunnerTriggerScriptableObject GunnerTriggerData;
    public GunnerTriggerScriptableObject GunnerData { get { return GunnerTriggerData; } }

    public static DataManager Instance;

    private void OnValidate()
    {
        Instance = this;
    }

    private void Awake()
    {
        Instance = this;
    }

    public static GunnerTriggerInfo GetGunnerTriggerInfo(GunnerTriggerType Type, FireArmType FireArm)
    {
        return Instance.GunnerTriggerData.GetData(Type, FireArm);
    }
}
