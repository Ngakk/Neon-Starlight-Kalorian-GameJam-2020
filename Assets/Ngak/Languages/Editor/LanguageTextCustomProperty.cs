using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace NgakUtilities.Languages
{
    [CustomPropertyDrawer(typeof(LanguageDatabase.LanguageText))]
    public class LanguageTextCustomProperty : PropertyDrawer
    {
        string selected = "";

        private bool selectedRetrieved = false;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            LanguageDatabase ld = LanguageDatabase.LanguagesAsset;

            bool noKeys = true;
            if (ld != null && ld.GetKeys() != null && ld.GetKeys().Count > 0) noKeys = false;

            SerializedProperty keyProperty = property.FindPropertyRelative("key");

            if (keyProperty != null && !selectedRetrieved)
            {
                selected = keyProperty.stringValue;
                selectedRetrieved = true;
            }
            else if(keyProperty != null)
            {
                keyProperty.stringValue = selected;
            }

            // Draw label
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            // Don't make child fields be indented
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            if (!noKeys)
            {
                // Calculate rects
                var ddRect = new Rect(position.x + 30, position.y, position.width - 30, position.height);

                // Draw fields - passs GUIContent.none to each so they are drawn without labels
                EditorGUI.LabelField(new Rect(ddRect.x - 30, ddRect.y, 30, position.height), "Key");
                if (EditorGUI.DropdownButton(ddRect, new GUIContent(selected), FocusType.Passive))
                {
                    Debug.Log("DropdownButton");
                    GenericMenu gm = new GenericMenu();

                    if (ld)
                    {
                        foreach (var s in ld.GetKeys())
                        {
                            gm.AddItem(new GUIContent(s), selected == s, OnKeySelected, s);
                        }
                    }

                    gm.DropDown(ddRect);
                }
            }
            else
            {
                var ddRect = new Rect(position.x + 100, position.y, position.width - 100, position.height);
                EditorGUI.LabelField(new Rect(ddRect.x - 100, ddRect.y, 100, position.height), "No keys");
                if (GUI.Button(ddRect, "Open Language Editor"))
                {
                    LanguageDatabaseEditorWindow.Init();
                }
            }

            // Set indent back to what it was
            EditorGUI.indentLevel = indent;

            EditorGUI.EndProperty();
        }

        void OnKeySelected(object key)
        {
            selected = key.ToString();
        }
    }
}