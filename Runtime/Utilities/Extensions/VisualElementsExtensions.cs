using UnityEngine.UIElements;

namespace SF.UIElements.Utilities
{
    public static class VisualElementsExtensions
    {
        public static T AddRow<T>(this T parent) where T : VisualElement
        {
            SFRow row = new();
            return parent.AddChild(row);
        }

        public static T AddChild<T>(this T parent, VisualElement child, string className = "") where T : VisualElement
        {
            if(!string.IsNullOrEmpty(className))
                child.AddToClassList(className);

            parent.Add(child);
            return parent;
        }
        public static T AddChild<T>(this T parent, VisualElement child, string[] classNames) where T : VisualElement
        {
            // Make sure we are not passing in an empty array
            if(classNames.Length > 0)
            {
                for(int i = 0; i < classNames.Length; i++)
                {
                    if(!string.IsNullOrEmpty(classNames[i]))
                        child.AddToClassList(classNames[i]);
                }
            }

            parent.Add(child);
            return parent;
        }

        public static T AddClass<T>(this T target, string className) where T : VisualElement
        {
            if(!string.IsNullOrEmpty(className))
                target.AddToClassList(className);
            return target;
        }
        /// <summary>
        /// Adds an every class name in the passed array to the class name list for the targetted visual element.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <param name="classNames"></param>
        /// <returns></returns>
        public static T AddClass<T>(this T target, string[] classNames) where T : VisualElement
        {
            if(classNames.Length > 0)
            {
                for(int i = 0; i < classNames.Length; i++)
                {
                    if(!string.IsNullOrEmpty(classNames[i]))
                        target.AddToClassList(classNames[i]);
                }
            }
            return target;
        }
    }
}
