using System.Collections.Generic;
using System.Reflection;
using System;

using Object = UnityEngine.Object;
using UnityEditor;

namespace SFEditor.UIElements
{
    public static class ObjectPickerExtensions
    {
        public static void ShowObjectPicker<T>(this T initialValue, Action<Object> OnSelectorClosed, Action<Object> OnSelectionChanged) where T : Object
        {
            ShowObjectPicker<T>(OnSelectorClosed, OnSelectionChanged, initialValue);
        }

        public static void ShowObjectPicker<T>(Action<Object> OnSelectorClosed, Action<Object> OnSelectionChanged, T initialValueOrNull = null) where T : Object
        {
            Type[] methodParameterTypes = new Type[]{
                typeof(T),
                typeof(Type),
                typeof(Object),
                typeof(bool),
                typeof(List<int>),
                typeof(Action<Object>),
                typeof(Action<Object>),
                typeof(bool)
            };

            MethodInfo hiddenMethod = GetHiddenMethodInfo(typeof(Editor).Assembly, "UnityEditor", "ObjectSelector", "Show", methodParameterTypes, out object os);

            hiddenMethod.Invoke(os, new object[]
                {
                initialValueOrNull,
                typeof(T),
                null,
                false,
                null,
                OnSelectorClosed,
                OnSelectionChanged,
                true
                }
            );
        }

        public static MethodInfo GetHiddenMethodInfo(Assembly assembly, string classNamespace, string className, string methodName, Type[] parameterTypes, out object os)
        {
            var hiddenType = assembly.GetType($"{classNamespace}.{className}");
            os = hiddenType.GetProperty("get", BindingFlags.Public | BindingFlags.Static).GetValue(null);

            return hiddenType.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance, null, parameterTypes, new ParameterModifier[0]);
        }

        public static MethodInfo GetHiddenMethodInfo(Assembly assembly, string classNamespace, string className, string methodName, Type[] parameterTypes)
        {
            var hiddenType = assembly.GetType($"{classNamespace}.{className}");

            return hiddenType.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance, null, parameterTypes, new ParameterModifier[0]);
        }
    }
}
