using UnityEditor;
using UnityEngine;

public class AssetUtilitiesEditor : EditorWindowBase
{

    [MenuItem("Tools/SF/Asset Utilities Editor")]
    public static void ShowEditor()
    {
        AssetUtilitiesEditor wnd = GetWindow<AssetUtilitiesEditor>();
        wnd.titleContent = new GUIContent("Asset Utilities Editor");
    }

    public void CreateGUI()
    {
        InitWindowAssets();
    }
}
