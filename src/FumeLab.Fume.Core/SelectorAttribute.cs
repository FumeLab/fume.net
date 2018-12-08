using System;

namespace FumeLab.Fume.Core
{
    public sealed class SelectorAttribute : Attribute
    {
        public Type Type { get; set; }

        public string Value { get; set; }

        public SelectorAttribute()
        {
        }

        public SelectorAttribute(Type type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}
