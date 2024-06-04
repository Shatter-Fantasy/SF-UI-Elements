using UnityEngine;
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
    }
}
