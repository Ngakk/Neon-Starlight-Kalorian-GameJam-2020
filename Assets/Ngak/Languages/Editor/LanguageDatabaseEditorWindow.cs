using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace NgakUtilities.Languages
{
    public class LanguageDatabaseEditorWindow : EditorWindow
    {
        private LanguageDatabase languageDatabase;
        private List<string> languages;
        private List<string> keys;
        private int selectedLanguage;
        private State state;

        private Rect contentRect;
        private float columnWidth;
        //Adding language
        private string languageValue;
        //Adding text
        private string keyValue;
        private string[] textValues;
        private Vector2 textsScroll;

        float padding = 5f;

        [MenuItem("Tools/Ngak/Language Editor")]
        public static void Init()
        {
            LanguageDatabaseEditorWindow wnd = GetWindow<LanguageDatabaseEditorWindow>();
            wnd.titleContent = new GUIContent("Language Editor");
            wnd.minSize = new Vector2(400, 500);
        }

        private void OnEnable()
        {
            GetLanguageAsset();
            GetLanguages();
            selectedLanguage = 0;
            state = State.MAIN;
        }

        private void OnGUI()
        {
            contentRect = new Rect(padding, padding, position.width - padding*2f, position.height - padding*2f);
            columnWidth = ((position.width - padding * 2f) / 2f);

            Event e = Event.current;
            Rect windoClickArea = new Rect(0, 0, 200, 200);
            contentRect = GUI.Window(0, contentRect, (x) => { }, "MyWindow");
            if (e.type == EventType.MouseDown && contentRect.Contains(e.mousePosition))
            {
                GUI.FocusControl(null);
            }

            GUILayout.BeginArea(contentRect);

            switch (state)
            {
                case State.MAIN:
                    MainGUI();
                    break;
                case State.ADDING_LANGUAGE:
                    AddingLanguageGUI();
                    break;
                case State.ADDING_TEXT:
                    AddingKeysGUI();
                    break;
            }

            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if(GUILayout.Button("Save", GUILayout.MaxWidth(100f), GUILayout.MinWidth(50f), GUILayout.ExpandWidth(true)))
            {
                SaveAsset();
            }
            GUILayout.EndHorizontal();

            GUILayout.EndArea();


            EditorUtility.SetDirty(languageDatabase);
        }

        void MainGUI()
        {
            //Add something buttons
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Add Language"))
            {
                ResetAddLanguageFields();
                state = State.ADDING_LANGUAGE;
            }
            if (GUILayout.Button("Add Key"))
            {
                ResetAddTextFields();
                state = State.ADDING_TEXT;
            }
            GUILayout.EndHorizontal();

            //Change language dispaly
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Prev", GUILayout.MinWidth(50f), GUILayout.MaxWidth(100f)))
            {
                selectedLanguage = Mathf.Max(selectedLanguage - 1, 0);
            }
            GUILayout.FlexibleSpace();
            if (languages.Count > 0)
                GUILayout.Label(languages[selectedLanguage], GUILayout.ExpandWidth(true));
            else
                GUILayout.Label("There are no languages", GUILayout.ExpandWidth(true));
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Next", GUILayout.MinWidth(50f), GUILayout.MaxWidth(100f)))
            {
                selectedLanguage = Mathf.Min(selectedLanguage + 1, languages.Count - 1);
            }
            GUILayout.EndHorizontal();


            //Column Headers
            if (keys.Count > 0)
            {
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                GUILayout.Label("Key");
                GUILayout.FlexibleSpace();
                GUILayout.Label("Value");
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
            }

            //Scroll View
            
            GUILayout.BeginScrollView(textsScroll);
            if (selectedLanguage < languages.Count)
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    GUILayout.BeginHorizontal();
                    GUILayout.Label(keys[i], GUILayout.Width(columnWidth));
                    string prevText = languageDatabase.GetText(keys[i], selectedLanguage);

                    languageDatabase.EditText(languages[selectedLanguage], keys[i],
                      GUILayout.TextField(prevText, GUILayout.Width(columnWidth-12)));

                    GUILayout.EndHorizontal();
                }
            }

            GUILayout.EndScrollView();
        }

        void AddingLanguageGUI()
        {
            AddingGUI("Language", ref languageValue, keys, AddLanguage);
        }

        void AddingKeysGUI()
        {
            AddingGUI("Key", ref keyValue, languages, AddTexts);
        }

        void AddingGUI(string _label, ref string _value, List<string> _arr, System.Action<string, string[]> _callback)
        {
            //Label
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label("Adding " + _label);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            //Input
            GUILayout.BeginHorizontal();
            GUILayout.Label(_label + ": ", GUILayout.Width(50f));
            _value = GUILayout.TextField(_value, GUILayout.ExpandWidth(true));
            GUILayout.EndHorizontal();

            GUILayout.BeginScrollView(textsScroll);
            if (_arr.Count == 0)
            {
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                GUILayout.Label("There are no " + _label.ToLower() + "s", GUILayout.Width(columnWidth));
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
            }
            for (int i = 0; i < _arr.Count; i++)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label(_arr[i]);
                textValues[i] = GUILayout.TextField(textValues[i], GUILayout.Width(columnWidth-12));
                GUILayout.EndHorizontal();
            }
            GUILayout.EndScrollView();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Cancel"))
            {
                state = State.MAIN;
            }
            if (GUILayout.Button("Add"))
            {
                _callback(_value, textValues);
                ResetMainFields();
                state = State.MAIN;
            }
            GUILayout.EndHorizontal();
        }

        void AddTexts(string _key, string[] _texts)
        {
            languageDatabase.AddText(_key, _texts);
            GetLanguages();
            SaveAsset();
        }

        void AddLanguage(string _language, string[] _texts)
        {
            languageDatabase.AddLanguage(_language, _texts);
            GetLanguages();
            SaveAsset();
        }

        void ResetMainFields()
        {
            textsScroll = Vector2.zero;
        }

        void ResetAddTextFields()
        {
            keyValue = "";
            textValues = new string[languages.Count];
            textsScroll = Vector2.zero;
        }

        void ResetAddLanguageFields()
        {
            languageValue = "";
            textValues = new string[keys.Count];
            textsScroll = Vector3.zero;
        }

        void GetLanguageAsset()
        {
            languageDatabase = LanguageDatabase.languagesAsset;
            
            if(languageDatabase == null)
            {
                languageDatabase = CreateInstance<LanguageDatabase>();

                string[] folders = (LanguageDatabase.path).Split('/');
                string currentFolder = folders[0];

                for (int i = 1; i < folders.Length; i++)
                {
                    if (!AssetDatabase.IsValidFolder(currentFolder + "/" + folders[i]))
                    {
                        AssetDatabase.CreateFolder(currentFolder, folders[i]);
                    }
                    currentFolder += "/" + folders[i];
                }

                AssetDatabase.CreateAsset(languageDatabase, LanguageDatabase.path + "/LanguageDatabase.asset");
                AssetDatabase.SaveAssets();
            }
        }

        void GetLanguages()
        {
            languages = languageDatabase.GetLanguages();
            keys = languageDatabase.GetKeys();

            if (languages == null) languages = new List<string>();
            if (keys == null) keys = new List<string>();
        }

        void SaveAsset()
        {
            Debug.Log("Saving language asset...");
            EditorUtility.SetDirty(languageDatabase);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private enum State
        {
            MAIN,
            ADDING_LANGUAGE,
            ADDING_TEXT
        }
    }
}