using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AstroidCube))]
[CanEditMultipleObjects]
public class AstroidCubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        AstroidCube ThisCube = (AstroidCube)target;

        base.DrawDefaultInspector();

        if (GUILayout.Button("Update Flight Path"))
        {
            ThisCube.UpdatePathing();
        }

        if (GUILayout.Button("Return Pathways"))
        {
            ThisCube.ReturnPathways();
        }
    }
}
