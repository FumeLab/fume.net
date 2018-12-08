using FumeLab.Fume.Core.Selectors;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium
{
    internal class SelectorMapper
    {
        public By Map(Selector selector) => By.Id(selector.Value);

        public By Map(Id selector) => By.Id(selector.Value);

        public By Map(Name selector) => By.Name(selector.Value);

        public By Map(ClassName selector) => By.ClassName(selector.Value);

        public By Map(Css selector) => By.CssSelector(selector.Value);

        public By Map(LinkText selector) => By.LinkText(selector.Value);

        public By Map(TagName selector) => By.TagName(selector.Value);

        public By Map(XPath selector) => By.XPath(selector.Value);
    }
}
