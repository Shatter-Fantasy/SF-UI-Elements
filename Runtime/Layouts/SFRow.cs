using System;

using UnityEngine.UIElements;

namespace SF.UIElements
{
    [UxmlElement]
    public partial class SFRow : VisualElement
    {
        [UxmlAttribute("two-column")] public bool TwoColumn { get; set; }
        public const string USSClassName = "sf-row";

        public SFRow()
        {
            AddToClassList(USSClassName);
            if(TwoColumn)
                AddToClassList("two-column");
        }

        public SFRow(string className) : this()
        {
            if(!string.IsNullOrEmpty(className))
                AddToClassList(className);
            
        }

        public SFRow(string[] classNames) : this()
        {
            if(classNames.Length < 1)
                return;

            for(int i = 0; i < classNames.Length; i++)
            {
                if(!string.IsNullOrEmpty(classNames[i]))
                    AddToClassList(classNames[i]);
            }
        }
    }
}
