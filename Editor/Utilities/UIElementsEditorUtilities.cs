using System;

using UnityEditor;
using static UnityEditor.AssetDatabase;
using UnityEngine.UIElements;
using System.Dynamic;
using UnityEngine;

namespace SFEditor.UIElements.Utilities
{

    public static class UIElementsEditorUtilities
    {
        /// <summary>
        /// Gets the first asset meeting the search filter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="searchFilter"></param>
        /// <returns></returns>
        public static T FindFirstAssetInPackages<T>(string searchFilter) where T : UnityEngine.Object
        {
            ReadOnlySpan<string> guids = FindAssets($"glob:\"Packages/**/*{searchFilter}\"");
            return LoadAssetAtPath<T>(GUIDToAssetPath(guids[0]));
        }

        public static bool TryFindFirstAssetInPackages<T>(string searchFilter, ref T asset) where T : UnityEngine.Object
        {
            ReadOnlySpan<string> guids = FindAssets($"glob:\"{searchFilter}\"");
            if(guids.IsEmpty)
                return false;
            asset = LoadAssetAtPath<T>(GUIDToAssetPath(guids[0]));
            return asset != null;
        }
    }
}
