using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class IsElementDisplayedQueryHandler : IQueryHandler<bool, IsDisplayed>
    {
        private readonly IWebElement _element;

        public IsElementDisplayedQueryHandler(IWebElement element)
        {
            _element = element;
        }
        public bool Handle(IQuery<IsDisplayed> query)
        {
            return _element.Displayed;
        }
    }
}
