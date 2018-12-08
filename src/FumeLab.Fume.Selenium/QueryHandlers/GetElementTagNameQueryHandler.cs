using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementTagNameQueryHandler : IQueryHandler<QueryResult<string>, GetTagName>
    {
        private readonly IWebDriver _driver;

        public GetElementTagNameQueryHandler(IWebDriver driver)
        {
            _driver = driver;
        }

        public QueryResult<string> Execute(GetTagName query)
        {
            return new QueryResult<string> { Value = _driver.FindElement(new SelectorMapper().Map(query.Selector)).TagName };
        }
    }
}
