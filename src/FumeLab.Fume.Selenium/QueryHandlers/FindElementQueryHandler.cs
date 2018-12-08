using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    internal class FindElementQueryHandler : IQueryHandler<IWebElement, FindElement>
    {
        private readonly IWebDriver _driver;

        public FindElementQueryHandler(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement Handle(IQuery<FindElement> query)
        {
            var selectorMapper = new SelectorMapper();
            return _driver.FindElement(selectorMapper.Map(query.Value.Selector));
        }
    }
}
