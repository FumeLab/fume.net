using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class IsElementCheckedQueryHandler : IQueryHandler<QueryResult<bool>, IsChecked>
    {
        private readonly IWebDriver _driver;

        public IsElementCheckedQueryHandler(IWebDriver driver)
        {
            _driver = driver;
        }

        public QueryResult<bool> Execute(IsChecked query)
        {
            return new QueryResult<bool> { Value = _driver.FindElement(new SelectorMapper().Map(query.Selector)).Selected };
        }
    }
}
