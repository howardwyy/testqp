namespace CodeBetter.Json
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using System.Reflection;
    using Helpers;

    public class JsonDeserializer
    {
        private static readonly Type _IListType = typeof(IList);
        private readonly JsonReader _reader;
        private readonly string _fieldPrefix;

        public JsonDeserializer(JsonReader reader) : this(reader, string.Empty) { }
        public JsonDeserializer(JsonReader reader, string fieldPrefix)
        {
            _reader = reader;
            _fieldPrefix = fieldPrefix;
        }

        public static T Deserialize<T>(JsonReader reader)
        {
            return Deserialize<T>(reader, string.Empty);
        }
        public static T Deserialize<T>(JsonReader reader, string fieldPrefix)
        {
            return (T)new JsonDeserializer(reader, fieldPrefix).DeserializeValue(typeof(T));
        }
        public static Object Deserialize(JsonReader reader, Type type)
        {
            return Deserialize(reader, string.Empty, type);
        }
        public static Object Deserialize(JsonReader reader, string fieldPrefix, Type type)
        {
            return new JsonDeserializer(reader, fieldPrefix).DeserializeValue(typeof(Type));
        }



        private object DeserializeValue(Type type)
        {
            _reader.SkipWhiteSpaces();
            if (type == typeof(int))
            {
                return _reader.ReadInt32();
            }
            if (type == typeof(string))
            {
                return _reader.ReadString();
            }
            if (type == typeof(bool))
            {
                return _reader.ReadBoolean();
            }
            if (type == typeof(double))
            {
                return _reader.ReadDouble();
            }
            if (type == typeof(DateTime))
            {
                return _reader.ReadDateTime();
            }
            if (_IListType.IsAssignableFrom(type))
            {
                return DeserializeList(type);
            }
            if (type == typeof(char))
            {
                return _reader.ReadChar();
            }
            if (type.IsEnum)
            {
                return _reader.ReadEnum();
            }
            if (type == typeof(long))
            {
                return _reader.ReadInt64();
            }
            if (type == typeof(float) || type == typeof(decimal))
            {
                float x = _reader.ReadFloat();
                if (type == typeof(decimal))
                    return decimal.Parse(x + "");
                else
                    return x;
            }
            if (type == typeof(short))
            {
                return _reader.ReadInt16();
            }
            return ParseObject(type);
        }
        private object DeserializeList(Type listType)
        {
            _reader.SkipWhiteSpaces();
            bool hasvalue = _reader.AssertAndConsume1(JsonTokens.StartArrayCharacter);
            if (!hasvalue)
                return null;
            Type itemType = ListHelper.GetListItemType(listType);
            bool isReadonly;
            IList container = ListHelper.CreateContainer(listType, itemType, out isReadonly);
            while (true)
            {
                _reader.SkipWhiteSpaces();
                container.Add(DeserializeValue(itemType));
                _reader.SkipWhiteSpaces();
                if (_reader.AssertNextIsDelimiterOrSeparator(JsonTokens.EndArrayCharacter))
                {
                    break;
                }
            }
            if (listType.IsArray)
            {
                return ListHelper.ToArray((List<object>)container, itemType);
            }
            if (isReadonly)
            {
                return listType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[] { container.GetType() }, null).Invoke(new object[] { container });
            }
            return container;
        }
        private object ParseObject(Type type)
        {
            bool hasvalue = _reader.AssertAndConsume1(JsonTokens.StartObjectLiteralCharacter);
            if (!hasvalue)
                return null;
            ConstructorInfo constructor = ReflectionHelper.GetDefaultConstructor(type);
            object instance = constructor.Invoke(null);
            while (true)
            {
                _reader.SkipWhiteSpaces();
                string name = _reader.ReadString();
                if (!name.StartsWith(_fieldPrefix))
                {
                    name = _fieldPrefix + name;
                }
                PropertyInfo field = ReflectionHelper.FindField1(type, name);
                _reader.SkipWhiteSpaces();
                _reader.AssertAndConsume1(JsonTokens.PairSeparator);
                _reader.SkipWhiteSpaces();
                if (field == null)//检查有没有此字段
                {
                    ReadAValue();
                    _reader.SkipWhiteSpaces();
                    if (_reader.AssertNextIsDelimiterOrSeparator(JsonTokens.EndObjectLiteralCharacter))
                    {
                        break;
                    }
                    continue;
                }
                field.SetValue(instance, DeserializeValue(field.PropertyType), null);
                _reader.SkipWhiteSpaces();
                if (_reader.AssertNextIsDelimiterOrSeparator(JsonTokens.EndObjectLiteralCharacter))
                {
                    break;
                }
            }
            return instance;
        }
        public virtual object ReadAValue()
        {
            char c = _reader.Peek();
            if (c == '\'' || c == '"')
                return _reader.ReadString();
            else if (c == '{')
            {
                return DeserializeValue(typeof(object));
            }
            else if (c == '[')
            {
                return DeserializeList(typeof(object[]));
            }
            else if (c == 'n')
            {
                _reader.Read();
                _reader.Read();
                _reader.Read();
                _reader.Read();
            }
            else if (c == 'f')
            {
                _reader.Read();
                _reader.Read();
                _reader.Read();
                _reader.Read();
                _reader.Read();
            }
            else if (c == 't')
            {
                _reader.Read();
                _reader.Read();
                _reader.Read();
                _reader.Read();
            }
            else
            {
                _reader.ReadFloat();
            }
            return "";
        }
    }
}