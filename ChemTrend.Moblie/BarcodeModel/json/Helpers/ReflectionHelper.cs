namespace CodeBetter.Json.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    internal static class ReflectionHelper
    {
        private readonly static Type _includeBaseAttributeType = typeof(SerializeIncludingBaseAttribute);
        private static readonly Type _nonSerializableAttributeType = typeof(NonSerializedAttribute);

        public static List<PropertyInfo> GetSerializableFields(Type type)
        {
            List<PropertyInfo> fields = new List<PropertyInfo>(10);
            fields.AddRange(type.GetProperties());
            RemoveNonSerializableFields(fields);
            if (type.BaseType != null && type.GetCustomAttributes(_includeBaseAttributeType, false).Length > 0)
            {
                fields.AddRange(GetSerializableFields(type.BaseType));
            }
            return fields;
        }

        private static void RemoveNonSerializableFields(List<PropertyInfo> fields)
        {
            for (int i = 0; i < fields.Count; ++i)
            {
                if (!ShouldSerializeField(fields[i]))
                {
                    fields.RemoveAt(i--);
                }
            }
        }

        public static bool ShouldSerializeField(ICustomAttributeProvider field)
        {
            return field.GetCustomAttributes(_nonSerializableAttributeType, true).Length <= 0;
        }

        public static PropertyInfo FindField1(Type type, string name)
        {
            PropertyInfo field = FindFieldThroughoutHierarchy(type, name);
            if (field == null)
            {
                //throw new ArgumentException(type.FullName + " doesn't have a field named: " + name);
                return null;
            }
            return field;
        }
        public static PropertyInfo FindFieldThroughoutHierarchy(Type type, string name)
        {
            PropertyInfo field = type.GetProperty(name);
            if (field == null && type.GetCustomAttributes(_includeBaseAttributeType, false).Length > 0)
            {
                field = FindFieldThroughoutHierarchy(type.BaseType, name);
            }
            return field;
        }

        public static object GetValue(PropertyInfo field, object obj)
        {
            object value = field.GetValue(obj, null);
            return (field.PropertyType.IsEnum) ? (int)value : value;
        }

        public static ConstructorInfo GetDefaultConstructor(Type type)
        {
            ConstructorInfo constructor = type.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);
            if (constructor == null)
            {
                throw new JsonException(type.FullName + " must have a parameterless constructor");
            }
            return constructor;
        }
    }
}
