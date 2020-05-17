using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerList : MonoBehaviour
{
    /// <summary>
    /// This will keep track of all the triggers
    /// </summary>

    // Parameters

    // Objects
    [SerializeField]
    private Trigger[] Triggers;

    // Variables
    public Astroid AstroidTrigger { get; internal set; }

    // Functions
    private void Awake()
    {
        
    }

    public void SetTriggers()
    {
        Triggers = GetComponentsInChildren<Trigger>();

        foreach (Trigger trigger in Triggers)
        {
            if (trigger.Type == FPS.Enums.TriggerType.Gunner)
            {
                if (trigger is Astroid)
                {
                    AstroidTrigger = trigger as Astroid;
                }
            }
        }
    }
}
