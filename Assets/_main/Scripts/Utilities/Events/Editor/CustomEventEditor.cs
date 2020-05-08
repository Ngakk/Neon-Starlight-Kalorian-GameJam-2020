using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CustomEvent))]
public class CustomEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CustomEvent s = (CustomEvent)target;

        if(GUILayout.Button("Play"))
        {
            s.Rise();
        }
    }
}
