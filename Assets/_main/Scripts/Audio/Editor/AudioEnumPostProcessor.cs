using UnityEngine;
using UnityEditor;

class AudioEnumPostProcessor : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        GenerateEnum.Go();
    }
}