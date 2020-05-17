using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TriggerList))]
[CanEditMultipleObjects]
public class TriggerListEditor : Editor
{
    public override void OnInspectorGUI()
    {
        TriggerList ThisList = (TriggerList)target;

        base.DrawDefaultInspector();

        if (GUILayout.Button("Set Up Triggers"))
        {
            ThisList.SetTriggers();
        }
    }
}
