#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;

public class GenerateEnum
{
    //[MenuItem("Tools/GenerateEnum")]
    public static void Go()
    {
        AudioClipListVariable aclv = Resources.Load<AudioClipListVariable>("Audio/AudioClipListVariable");

        string enumName = "DeezNuts";
        string[] enumEntries = new string[aclv.clipGroups.Count];

        for(int i = 0; i < aclv.clipGroups.Count; i++)
        {
            enumEntries[i] = aclv.clipGroups[i].name.Replace(" ", "_").ToUpper();
        }

        string filePathAndName = "Assets/_main/Scripts/Enums/" + enumName + ".cs"; //The folder Scripts/Enums/ is expected to exist

        using (StreamWriter streamWriter = new StreamWriter(filePathAndName))
        {
            streamWriter.WriteLine("public enum " + enumName);
            streamWriter.WriteLine("{");
            for (int i = 0; i < enumEntries.Length; i++)
            {
                streamWriter.WriteLine("\t" + enumEntries[i] + ",");
            }
            streamWriter.WriteLine("}");
        }
        AssetDatabase.Refresh();
    }
}
#endif