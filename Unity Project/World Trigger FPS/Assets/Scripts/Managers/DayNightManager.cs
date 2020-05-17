using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightManager : MonoBehaviour
{
    [SerializeField]
    private Transform DayNightTransform;
    [SerializeField]
    private Light DayNightLight;

    public static DayNightManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void SetDay()
    {
            DayNightLight.enabled = true;
    }

    public void SetNight()
    {
        DayNightLight.enabled = false;
    }
}
