﻿using System;

namespace ShareFile.Api.Models
{
    public interface ISafeEnum
    {
        object Object { set; }
        string Value { get; set; }
    }

    public struct SafeEnum<TEnumSource> : ISafeEnum
        where TEnumSource : struct
    {
        private TEnumSource? _enum;
        public TEnumSource? Enum
        {
            get { return _enum; }
            set
            {
                _enum = value;
                if (null != value)
                {
                    _value = value.Value.ToString();
                }
            }
        }

        public object Object
        {
            set { Enum = (TEnumSource)value; }
        }

        private string _value;
        public string Value
        {
            get { return _value ?? (Enum.HasValue ? Enum.Value.ToString() : null); }
            set { _value = value; }
        }

        public static SafeEnum<TSource> Create<TSource>(TSource enumSourceValue)
            where TSource : struct
        {
            var instance = Activator.CreateInstance<SafeEnum<TSource>>();
            instance.Enum = enumSourceValue;

            return instance;
        }
    }
}
