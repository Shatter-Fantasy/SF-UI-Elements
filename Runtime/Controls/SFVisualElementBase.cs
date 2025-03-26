using SF.UIElements.Utilities;
using UnityEngine;
using UnityEngine.UIElements;

namespace SF.UIElements
{
    [UxmlElement]
    public partial class SFVisualElementBase : VisualElement
    {
        public const string USSClassName = "sf-element";
        
        public SFVisualElementBase()
        {
            this.AddClass(USSClassName);
        }
    }
}
