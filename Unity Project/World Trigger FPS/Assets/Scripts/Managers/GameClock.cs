using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Enums;

public class GameClock : MonoBehaviour
{
    [SerializeField]
    private float GameDayScale = 1;
    public static float GameTimeScale = 1;
    public static float SecToHourConversion = 3600;
    public float TimeScale { get { return GameTimeScale; } set { ChangeTimeScale(value); } }
    public static float DeltaTime = 0.02f;
    [SerializeField]
    private TimeOfDay StartTime = TimeOfDay.Noon;
    public static TimeOfDay DayTime = TimeOfDay.Morning;
    public static float Clock = 0;


    // Start is called before the first frame update
    void Awake()
    {
        DeltaTime = GameTimeScale * Time.fixedDeltaTime;
        DayTime = StartTime;
        Clock = GetTimeOfDayConversion(DayTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeOfDayUpdate();
    }

    private void TimeOfDayUpdate()
    {
        Clock += DeltaTime;
        if (Clock >= 6 * GameDayScale / SecToHourConversion) // 6 am
        {
            DayTime = TimeOfDay.Morning;
            DayNightManager.Instance.SetDay();
        }
        else if (Clock >= 12 * GameDayScale / SecToHourConversion) // Noon
        {
            DayTime = TimeOfDay.Noon;
        }
        else if (Clock >= 13 * GameDayScale / SecToHourConversion) // Noon
        {
            DayTime = TimeOfDay.AfterNoon;
        }
        else if (Clock >= 18 * GameDayScale / SecToHourConversion) // Evening
        {
            DayTime = TimeOfDay.Evening;
        }
        else if (Clock >= 22 * GameDayScale / SecToHourConversion) // Evening
        {
            DayTime = TimeOfDay.Night;
            DayNightManager.Instance.SetNight();
        }
        else if (Clock >= 24 * GameDayScale / SecToHourConversion) // Evening
        {
            DayTime = TimeOfDay.MidNight;
            Clock = 0;
        }
        else
        {
            DayTime = TimeOfDay.EarlyMorning;
        }
    }

    public void ChangeTimeScale(float Scale)
    {
        GameTimeScale = Scale;
        DeltaTime = GameTimeScale * Time.fixedDeltaTime;
    }

    public static float GetTimeOfDayConversion(TimeOfDay TimeOfDayStart)
    {
        switch (TimeOfDayStart)
        {
            case TimeOfDay.EarlyMorning:
                return 0;
            case TimeOfDay.Morning:
                return 6;
            case TimeOfDay.Noon:
                return 12;
            case TimeOfDay.AfterNoon:
                return 13;
            case TimeOfDay.Evening:
                return 18;
            case TimeOfDay.Night:
                return 22;
            case TimeOfDay.MidNight:
                return 24;
        }

        return 0;
    }
}

namespace FPS.Enums
{
    public enum TimeOfDay
    {
        EarlyMorning,
        Morning,
        Lunch,
        Noon,
        AfterNoon,
        Evening,
        Night,
        MidNight,
    }
}

