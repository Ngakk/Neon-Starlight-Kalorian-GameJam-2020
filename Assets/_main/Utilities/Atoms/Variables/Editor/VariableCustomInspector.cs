using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Variable))]
public class VariableCustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Variable s = (Variable)target;

        if(GUILayout.Button("Invoke On Value Changed"))
        {
            s.ValueChanged();
        }
    }
}

[CustomEditor(typeof(IntVariable))]
public class IntVariableCustomInspector : VariableCustomInspector { }

[CustomEditor(typeof(FloatVariable))]
public class FloatVariableCustomInspector : VariableCustomInspector { }
