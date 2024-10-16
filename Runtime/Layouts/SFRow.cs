using UnityEngine.UIElements;

namespace SF.UIElements
{
    [UxmlElement]
    public partial class SFRow : VisualElement
    {
        public const string USSClassName = "row";

        public SFRow()
        {
            AddToClassList(USSClassName);
        }

        public SFRow(string className) : this()
        {
            if(!string.IsNullOrEmpty(className))
                AddToClassList(className);
        }
    }
}
