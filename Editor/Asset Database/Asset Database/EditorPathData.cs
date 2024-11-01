using UnityEngine;
using UnityEngine.UIElements;

namespace SF.Editor.Utilities
{
    [CreateAssetMenu(fileName = "Editor Path Data", menuName = "SF/Asset Management/Editor Path Data")]
    public class EditorPathData : ScriptableObject
    {
		/// <summary> This is by default the same as Unity Editor Utility Path. </summary>
		[SerializeField] private string DefaultBasePath = "Assets/Editor Default Resources/";
        /// <summary>Set this to allow for a custom base path instead of the default one. </summary>
        [SerializeField] private string CustomBasePath = "";
        // TODO: Add a check to make sure the path does exist.
        // TODO: make an error box appear if their is no path.
        public string BasePath
        {
            get
            {
				if(string.IsNullOrEmpty(CustomBasePath))
                    return DefaultBasePath;

                else return CustomBasePath;
			}
        }

        public string DataPath { get => BasePath + "Data/"; }
	}
}
