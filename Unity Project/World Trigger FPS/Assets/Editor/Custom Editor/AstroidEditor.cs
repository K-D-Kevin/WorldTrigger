using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Astroid))]
[CanEditMultipleObjects]

public class AstroidEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Astroid ThisCube = (Astroid)target;

        base.DrawDefaultInspector();

        if (GUILayout.Button("Update Flight Paths"))
        {
            ThisCube.UpdateCubes();
        }

        if (GUILayout.Button("Return Pathways"))
        {
            ThisCube.ReturnPathways();
        }

        if (GUILayout.Button("Create New Astroid Block"))
        {
            ThisCube.CreateNewAstroid();
        }
    }
}
