using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Hitbox))]
public class HitboxEditor : Editor
{
    bool editDirection = false;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Hitbox t = (Hitbox)target;

        if(GUILayout.Button("Reset direction"))
        {
            t.hitData.rotation = Quaternion.identity;
        }
        editDirection = GUILayout.Toggle(editDirection, "Edit Direction");
    }

    private void OnSceneGUI()
    {
        if (!editDirection) return;
        Hitbox t = (Hitbox)target;

        EditorGUI.BeginChangeCheck();

        /*if (t.hitData.direction.magnitude == 0)
            t.hitData.direction = Vector3.forward;*/

        Quaternion rot = Handles.RotationHandle(t.hitData.rotation, t.transform.position + Vector3.up * 2);
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(target, "Rotated RotateAt Point");
            Debug.Log("rot: " + rot);
            t.hitData.rotation = Quaternion.Euler(Vector3.Scale(rot.eulerAngles, Vector3.up));
        }
    }
}
