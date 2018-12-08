using FumeLab.Fume.Core.Selectors;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium
{
    internal class SelectorMapper
    {
        public By Map(Selector selector)
        {
            switch (selector)
            {
                case Id id:
                    return By.Id(selector.Value);
                case Name name:
                    return By.Name(selector.Value);
                case ClassName className:
                    return By.ClassName(selector.Value);
                case Css css:
                    return By.CssSelector(selector.Value);
                case LinkText linkText:
                    return By.LinkText(selector.Value);
                case TagName tagName:
                    return By.TagName(selector.Value);
                case XPath xPath:
                    return By.XPath(selector.Value);
                default:
                    return By.Id(selector.Value);
            }
        }
    }
}
