using System;

using UnityEngine;
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

        /// <summary>
        /// Adds the sf-row--item uss class name to the first depth children.
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static T SetChildrenAsRowItems<T>(this T parent) where T : VisualElement
        {
            foreach(var child in parent.Children())
            {
                child.AddToClassList("sf-row--item");
            }
            return parent;
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
            parent.CheckNullElements(child);

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

        /// <summary>
        /// Will log an error if either the child or parent UI Element is null.
        /// Doesn't stop the sequence of method chaining in progress. You have to do that in the calling method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <param name="bindingPath"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static T AddBindableChild<T,U>(this T parent, U child, string bindingPath, string className = "") where T : VisualElement where U : BindableElement
        {
            parent.CheckNullElements(child);

            if(!string.IsNullOrEmpty(bindingPath))
                child.bindingPath = bindingPath;

            return parent.AddChild(child,className);
        }

        private static T CheckNullElements<T,U>(this T parent, U child) where T : VisualElement where U : VisualElement
        {
            if(parent == null)
            {
                Debug.LogError("The parent visual element that is having a child element added to is null.");
                return null;
            }

            if(child == null)
            {
                Debug.LogError($"The passed in child trying to be added to {parent} is null.");
                return parent;
            }

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

        public static T Rename<T>(this T target, string newName) where T : VisualElement
        {
            if(target != null)
                target.name = newName;
            return target;
        }

        public static T SetAllBorders<T>(this T target, int borderWidth, Color borderColor) where T : VisualElement
        {
            target.style.borderTopColor = borderColor;
            target.style.borderRightColor = borderColor;
            target.style.borderBottomColor = borderColor;
            target.style.borderLeftColor = borderColor;

            target.style.borderTopWidth = borderWidth;
            target.style.borderRightWidth = borderWidth;
            target.style.borderLeftWidth = borderWidth;
            target.style.borderBottomWidth = borderWidth;

            return target;
        }
    }
}
