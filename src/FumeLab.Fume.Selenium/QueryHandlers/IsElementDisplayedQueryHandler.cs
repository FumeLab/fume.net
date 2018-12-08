using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class IsElementDisplayedQueryHandler : IQueryHandler<QueryResult<bool>, IsDisplayed>
    {
        private readonly IWebDriver _driver;

        public IsElementDisplayedQueryHandler(IWebDriver driver)
        {
            _driver = driver;
        }

        public QueryResult<bool> Execute(IsDisplayed query)
        {
            return new QueryResult<bool> { Value = _driver.FindElement(new SelectorMapper().Map(query.Selector)).Displayed };
        }
    }
}
