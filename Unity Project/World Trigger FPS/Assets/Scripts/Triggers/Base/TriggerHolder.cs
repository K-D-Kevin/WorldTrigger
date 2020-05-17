using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHolder : MonoBehaviour
{
    [SerializeField]
    private List<Trigger> Triggers = new List<Trigger>();

    private Trigger[] MainTrigger = new Trigger[4];
    public Trigger[] MainTriggers { get { return MainTrigger; } set { MainTrigger = value; } }
    private Trigger[] SubTrigger = new Trigger[4];
    public Trigger[] SubTriggers { get { return SubTrigger; } set { SubTrigger = value; } }

    public Trigger ActiveMainTrigger { get; internal set; }
    private int ActiveMainTriggerIndex = 0;

    public Trigger ActiveSubTrigger { get; internal set; }
    private int ActiveSubTriggerIndex = 0;

    private void Awake()
    {
        for (int i = 0; i < Triggers.Count; i++)
        {
            if (Triggers[i] == null)
            {
                break;
            }
            if (i < 4)
            {
                MainTrigger[i] = Triggers[i];
            }
            else
            {
                SubTrigger[i] = Triggers[i];
            }
        }
        ActiveMainTrigger = MainTrigger[0];
        ActiveSubTrigger = SubTrigger[0];
    }

    // Main Trigger Functions
    public Trigger ToggleRightMainTrigger()
    {
        ActiveMainTrigger.Unequip();
        ActiveMainTriggerIndex++;
        if (ActiveMainTriggerIndex == 4)
        {
            ActiveMainTriggerIndex = 0;
        }
        ActiveMainTrigger = MainTrigger[ActiveMainTriggerIndex];
        ActiveMainTrigger.Equip();
        return ActiveMainTrigger;
    }

    public Trigger ToggleLeftMainTrigger()
    {
        ActiveMainTrigger.Unequip();
        ActiveMainTriggerIndex--;
        if (ActiveMainTriggerIndex == -1)
        {
            ActiveMainTriggerIndex = 3;
        }
        ActiveMainTrigger = MainTrigger[ActiveMainTriggerIndex];
        ActiveMainTrigger.Equip();
        return ActiveMainTrigger;
    }

    public Trigger SetMainToSlotOne()
    {
        if (ActiveMainTriggerIndex != 0)
        {
            ActiveMainTrigger.Unequip();
            ActiveMainTriggerIndex = 0;
            ActiveMainTrigger = MainTrigger[ActiveMainTriggerIndex];
            ActiveMainTrigger.Equip();
        }
        return ActiveMainTrigger;
    }

    public Trigger SetMainToSlotTwo()
    {
        if (ActiveMainTriggerIndex != 1)
        {
            ActiveMainTrigger.Unequip();
            ActiveMainTriggerIndex = 1;
            ActiveMainTrigger = MainTrigger[ActiveMainTriggerIndex];
            ActiveMainTrigger.Equip();
        }
        return ActiveMainTrigger;
    }

    public Trigger SetMainToSlotThree()
    {
        if (ActiveMainTriggerIndex != 2)
        {
            ActiveMainTrigger.Unequip();
            ActiveMainTriggerIndex = 2;
            ActiveMainTrigger = MainTrigger[ActiveMainTriggerIndex];
            ActiveMainTrigger.Equip();
        }
        return ActiveMainTrigger;
    }

    public Trigger SetMainToSlotFour()
    {
        if (ActiveMainTriggerIndex != 3)
        {
            ActiveMainTrigger.Unequip();
            ActiveMainTriggerIndex = 3;
            ActiveMainTrigger = MainTrigger[ActiveMainTriggerIndex];
            ActiveMainTrigger.Equip();
        }
        return ActiveMainTrigger;
    }

    public void UnequipCurrentMain()
    {
        ActiveMainTrigger.Unequip();
    }

    public void EquipCurrentMain()
    {
        ActiveMainTrigger.Equip();
    }

    // Sub Trigger Functions
    public Trigger ToggleRightSubTrigger()
    {
        ActiveSubTrigger.Unequip();
        ActiveSubTriggerIndex++;
        if (ActiveSubTriggerIndex == 4)
        {
            ActiveSubTriggerIndex = 0;
        }
        ActiveSubTrigger = SubTrigger[ActiveSubTriggerIndex];
        ActiveSubTrigger.Equip();
        return ActiveSubTrigger;
    }

    public Trigger ToggleLeftSubTrigger()
    {
        ActiveSubTrigger.Unequip();
        ActiveSubTriggerIndex--;
        if (ActiveSubTriggerIndex == -1)
        {
            ActiveSubTriggerIndex = 3;
        }
        ActiveSubTrigger = SubTrigger[ActiveSubTriggerIndex];
        ActiveSubTrigger.Equip();
        return ActiveSubTrigger;
    }

    public Trigger SetSubToSlotOne()
    {
        if (ActiveSubTriggerIndex != 0)
        {
            ActiveSubTrigger.Unequip();
            ActiveSubTriggerIndex = 0;
            ActiveSubTrigger = SubTrigger[ActiveSubTriggerIndex];
            ActiveSubTrigger.Equip();
        }
        return ActiveSubTrigger;
    }

    public Trigger SetSubToSlotTwo()
    {
        if (ActiveSubTriggerIndex != 1)
        {
            ActiveSubTrigger.Unequip();
            ActiveSubTriggerIndex = 1;
            ActiveSubTrigger = SubTrigger[ActiveSubTriggerIndex];
            ActiveSubTrigger.Equip();
        }
        return ActiveSubTrigger;
    }

    public Trigger SetSubToSlotThree()
    {
        if (ActiveSubTriggerIndex != 2)
        {
            ActiveSubTrigger.Unequip();
            ActiveSubTriggerIndex = 2;
            ActiveSubTrigger = SubTrigger[ActiveSubTriggerIndex];
            ActiveSubTrigger.Equip();
        }
        return ActiveSubTrigger;
    }

    public Trigger SetSubToSlotFour()
    {
        if (ActiveSubTriggerIndex != 3)
        {
            ActiveSubTrigger.Unequip();
            ActiveSubTriggerIndex = 3;
            ActiveSubTrigger = SubTrigger[ActiveSubTriggerIndex];
            ActiveSubTrigger.Equip();
        }
        return ActiveSubTrigger;
    }

    public void UnequipCurrentSub()
    {
        ActiveSubTrigger.Unequip();
    }

    public void EquipCurrentSub()
    {
        ActiveSubTrigger.Equip();
    }
}
