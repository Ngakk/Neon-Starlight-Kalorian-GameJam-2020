using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(InspectorPlayer))]
public class InspectorPlayerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        InspectorPlayer s = (InspectorPlayer)target;

        if(GUILayout.Button("Play"))
        {
            s.PlayEvent();
        }
    }
}
