using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AudioClipListVariable))]
public class AudioClipListVariableEditor : Editor
{
    List<SerializedProperty> clipFields;

    string newGroupName;
    bool showError;

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        AudioClipListVariable t = (AudioClipListVariable)target;

        for(int i = 0; i < t.clipGroups.Count; i++)
        {
            GUILayout.BeginHorizontal();
            //t.clipGroups[i].name = GUILayout.TextField(t.clipGroups[i].name);
            GUILayout.Label("Group: " + t.clipGroups[i].name);
            if(GUILayout.Button("Remove", GUILayout.MaxWidth(50f), GUILayout.MinWidth(25f), GUILayout.ExpandWidth(true)))
            {
                t.RemoveGroup(t.clipGroups[i].name);
            }
            GUILayout.EndHorizontal();

            if (i >= t.clipGroups.Count)
            {
                i--;
                break;
            }

            for(int j = 0; j < t.clipGroups[i].clips.Count; j++)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Space(40);
                GUILayout.Label(j + ". ", GUILayout.Width(20f));
                GUILayout.FlexibleSpace();
                t.clipGroups[i].clips[j] = EditorGUILayout.ObjectField(t.clipGroups[i].clips[j], typeof(AudioClip), false, GUILayout.MaxWidth(300f)) as AudioClip;
                GUILayout.EndHorizontal();
            }

            GUILayout.BeginHorizontal();
            GUILayout.Space(40);
            GUILayout.Label("New clip: ");
            GUILayout.FlexibleSpace();
            AudioClip newClip = EditorGUILayout.ObjectField(null, typeof(AudioClip), false,  GUILayout.MaxWidth(300f)) as AudioClip;
            if(newClip != null)
            {
                t.clipGroups[i].clips.Add(newClip);
            }
            GUILayout.EndHorizontal();
        }
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("New group name: ", GUILayout.MinWidth(10), GUILayout.ExpandWidth(false));

        string prevGroupName = newGroupName;
        newGroupName = GUILayout.TextField(newGroupName, GUILayout.ExpandWidth(true));
        if (newGroupName != prevGroupName)
            showError = false;
        
        if(GUILayout.Button("Add", GUILayout.MaxWidth(50f), GUILayout.MinWidth(25f), GUILayout.ExpandWidth(true)))
        {
            bool alreadyExists = false;
            foreach(var cg in t.clipGroups)
            {
                if(newGroupName == cg.name)
                {
                    alreadyExists = true;
                    break;
                }
            }
            if (!alreadyExists)
            {
                t.clipGroups.Add(new AudioClipListVariable.AudioClipGroup(newGroupName));
                newGroupName = "";
            }
            else
                showError = true;
        }
        GUILayout.EndHorizontal();

        if(showError)
        {
            EditorGUILayout.HelpBox("Name is already taken", MessageType.Error);
        }
    }

}
