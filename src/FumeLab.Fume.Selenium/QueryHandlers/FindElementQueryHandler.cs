using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    internal class FindElementQueryHandler : IQueryHandler<QueryResult<IWebElement>, FindElement>
    {
        private readonly IWebDriver _driver;

        public FindElementQueryHandler(IWebDriver driver)
        {
            _driver = driver;
        }
        public QueryResult<IWebElement> Handle(FindElement query)
        {
            return new QueryResult<IWebElement> { Value = _driver.FindElement(new SelectorMapper().Map(query.Selector))};
        }
    }
}
