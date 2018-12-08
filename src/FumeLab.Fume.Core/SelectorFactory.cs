using System;
using System.Collections.Generic;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core
{
    public class SelectorFactory
    {
        private static readonly Dictionary<Type, Func<string, Selector>> SupportedTypesCatalogue =
            new Dictionary<Type, Func<string, Selector>>();

        static SelectorFactory()
        {
            SupportedTypesCatalogue.Add(typeof(Id), (value) => new Id {Value = value});
            SupportedTypesCatalogue.Add(typeof(Name), (value) => new Name {Value = value});
        }

        public Selector Create(Type elemenType, string value)
        {
            return SupportedTypesCatalogue[elemenType].Invoke(value);
        }
    }
}
