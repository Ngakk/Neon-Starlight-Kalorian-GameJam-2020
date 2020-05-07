using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DontDestroyOnLoad))]
public class DontDestroyOnLoadEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        DontDestroyOnLoad s = (DontDestroyOnLoad)target;

        s.isUnique = EditorGUILayout.Toggle("Is Unique", s.isUnique);

        if(s.isUnique)
        {
            s.uniqueName = EditorGUILayout.TextField("Unique Name", s.uniqueName);

            if(!s.CompareTag("Persistent"))
            {
                if(GUILayout.Button("Set up persistent tag"))
                {
                    var tags = UnityEditorInternal.InternalEditorUtility.tags;
                    bool exists = false;
                    foreach(var t in tags)
                    {
                        if (t == "Persistent")
                        {
                            exists = true;
                            break;
                        }
                    }

                    if(!exists)
                    {
                        UnityEditorInternal.InternalEditorUtility.AddTag("Persistent");
                    }

                    s.gameObject.tag = "Persistent";
                }
            }
        }
    }
}
