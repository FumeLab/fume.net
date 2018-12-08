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
            SupportedTypesCatalogue.Add(typeof(TagName), (value) => new TagName {Value = value});
            SupportedTypesCatalogue.Add(typeof(ClassName), (value) => new ClassName {Value = value});
            SupportedTypesCatalogue.Add(typeof(CssSelector), (value) => new CssSelector {Value = value});
            SupportedTypesCatalogue.Add(typeof(LinkText), (value) => new LinkText {Value = value});
            SupportedTypesCatalogue.Add(typeof(PartialLinkText), (value) => new PartialLinkText {Value = value});
            SupportedTypesCatalogue.Add(typeof(XPath), (value) => new XPath {Value = value});
        }

        public Selector Create(Type elementType, string value)
        {
            return SupportedTypesCatalogue[elementType].Invoke(value);
        }
    }
}
