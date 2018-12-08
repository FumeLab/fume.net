using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Selectors;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class IsElementEnabledQueryHandler : IQueryHandler<bool, IsEnabled>
    {
        private readonly IWebElement _element;

        public IsElementEnabledQueryHandler(IWebElement element)
        {
            _element = element;
        }
        public bool Handle(IQuery<IsEnabled> query)
        {
            return _element.Enabled;
        }
    }
}
