using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NgakUtilities.Languages
{
    [CreateAssetMenu()]
    public class LanguageDatabase : ScriptableObject
    {
        [SerializeField] private Dictionary<string, LanguagePack> languagePacks;
        [SerializeField] private List<string> keys;
        [SerializeField] private List<string> languages;
        [SerializeField] private List<LanguagePack> serializedLanguagePacks = new List<LanguagePack>();
        [SerializeField] private int currentLanguage;

        public LanguageText tempText;

        public static string path = "Assets/Ngak/Resources/Languages";
        public static string resourcePath = "Languages/LanguageDatabase";

        private Dictionary<string, LanguagePack> LanguagePacks
        {
            get
            {
                if (languagePacks == null)
                {
                    languagePacks = new Dictionary<string, LanguagePack>();
                    for (int i = 0; i < languages.Count && i < serializedLanguagePacks.Count; i++)
                    {
                        languagePacks.Add(languages[i], serializedLanguagePacks[i]);
                    }
                }
                return languagePacks;
            }
        }
        private List<string> Keys
        {
            get
            {
                if (keys == null) keys = new List<string>();
                return keys;
            }
        }
        private List<string> Languages
        {
            get
            {
                if (languages == null) languages = new List<string>();
                return languages;
            }
        }

        public static LanguageDatabase languagesAsset;
        public static LanguageDatabase LanguagesAsset
        {
            get
            {
                if (languagesAsset == null)
                {
                    languagesAsset = Resources.Load<LanguageDatabase>(resourcePath);
                }
                return languagesAsset;
            }
        }

        [Header("Debug")]
        public int languagePackCount = 0;
        public int keyCount = 0;
        public int languageCount = 0;

        private void OnValidate()
        {
            languagePackCount = LanguagePacks.Count;
            keyCount = Keys.Count;
            languageCount = Languages.Count;
        }

        public List<string> GetKeys()
        {
            return Keys;
        }

        public void SetLanguage(int _i)
        {
            currentLanguage = _i;
            currentLanguage = Mathf.Max(Mathf.Min(currentLanguage, LanguagePacks.Count - 1), 0);
        }

        public void AddLanguage(string _languageName, string[] _texts = null)
        {
            Debug.Log("Language Asset - Adding Language");
            LanguagePack temp = new LanguagePack(_languageName);

            bool textsAreValid = _texts != null && _texts.Length == Keys.Count;

            if (textsAreValid) Debug.Log("Texts were valid");
            else Debug.Log("Texts were invalid, texts sent: " + (_texts == null ? "Null" : _texts.Length.ToString()) + ", key count: " + Keys.Count);

            for (int i = 0; i < Keys.Count; i++)
            {
                string text = textsAreValid ? _texts[i] : Keys[i]; 
                temp.Add(Keys[i], text);
            }

            LanguagePacks.Add(_languageName, temp);
            serializedLanguagePacks.Add(temp);
            Languages.Add(_languageName);
        }

        public void AddText(string _key, string[] _texts = null)
        {
            Debug.Log("Language Asset - Adding Key");
            Keys.Add(_key);

            bool textsAreValid = _texts != null && _texts.Length == Keys.Count;

            for(int i = 0; i < Languages.Count; i++)
            {
                string text = textsAreValid ? _texts[i] : _key;
                LanguagePacks[Languages[i]].Add(_key, text);
            }
        }

        public void RemoveText(string _key)
        {
            Keys.Remove(_key);

            foreach (var l in Languages)
            {
                LanguagePacks[l].Remove(_key);
            }
        }

        public void EditText(string _language, string _key, string _newText)
        {
            LanguagePacks[_language].Texts[_key] = _newText;
        }

        public string GetText(string _key, int _lang = -1)
        {
            if (_lang == -1) _lang = currentLanguage;
            if (_lang >= languagePacks.Count) return "MISSING_LANGUAGE_" + _key;
            return LanguagePacks[Languages[_lang]].Texts[_key];
        }

        public List<string> GetLanguages()
        {
            return Languages;
        }

        [System.Serializable]
        public class LanguagePack
        {
            public string languageName;

            private List<string> serializedKeys, serializedValues;
            private Dictionary<string, string> texts;
            
            public Dictionary<string, string> Texts
            {
                get
                {
                    if(texts == null)
                    {
                        texts = new Dictionary<string, string>();
                        for(int i = 0; i < serializedKeys.Count && i < serializedValues.Count; i++)
                        {
                            texts.Add(serializedKeys[i], serializedValues[i]);
                        }
                    }
                    return texts;
                }
            }

            public void Add(string _key, string _value)
            {
                serializedKeys.Add(_key);
                serializedValues.Add(_value);
                texts.Add(_key, _value);
            }

            public void Remove(string _key)
            {
                if(texts.ContainsKey(_key))
                {
                    serializedValues.Remove(texts[_key]);
                    serializedKeys.Remove(_key);
                    texts.Remove(_key);
                }
            }

            public LanguagePack(string languageName)
            {
                this.languageName = languageName;
                texts = new Dictionary<string, string>();
                serializedKeys = new List<string>();
                serializedValues = new List<string>();
            }
        }

        [System.Serializable]
        public class LanguageText
        {
            [SerializeField] private string text;
            [SerializeField] private string key;

            private string lastKeyUsed;

            public string Key
            {
                get
                {
                    return key;
                }
                set
                {
                    key = value;
                    SetText();
                }
            }



            public LanguageText(string key)
            {
                this.key = key;
                SetText();
            }

            public static implicit operator string(LanguageText lt)
            {
                if (lt.lastKeyUsed != lt.key)
                    lt.SetText();

                return lt.text;
            }

            private void SetText()
            {
                if (LanguagesAsset)
                {
                    lastKeyUsed = key;
                    text = languagesAsset.GetText(key);
                }
                else
                {
                    text = "MISSING_TEXT: " + key;
                }
            }
        }
    }
}