using System;

using UnityEngine.UIElements;

namespace SF.UIElements
{
    [UxmlElement]
    public partial class SFRow : VisualElement
    {
        [Obsolete("We are now using sf-row as the class to to prevent any conflicts with clas names users write them selves. This is just kept to prevent breaking projects already using it.")]
        public const string ObsoleteUSSClassName = "row";
        public const string USSClassName = "sf-row";

        public SFRow()
        {
            AddToClassList(USSClassName);
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
