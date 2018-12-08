using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class IsElementEnabledQueryHandler : IQueryHandler<QueryResult<bool>, IsEnabled>
    {
        private readonly IWebDriver _driver;

        public IsElementEnabledQueryHandler(IWebDriver driver)
        {
            _driver = driver;
        }

        public QueryResult<bool> Execute(IsEnabled query)
        {
            return new QueryResult<bool> { Value = _driver.FindElement(new SelectorMapper().Map(query.Selector)).Enabled };
        }
    }
}
