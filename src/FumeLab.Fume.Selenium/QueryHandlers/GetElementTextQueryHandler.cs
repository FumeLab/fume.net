using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementTextQueryHandler : IQueryHandler<QueryResult<string>, GetText>
    {
        private readonly IWebDriver _driver;

        public GetElementTextQueryHandler(IWebDriver driver)
        {
            _driver = driver;
        }

        public QueryResult<string> Execute(GetText query)
        {
            return new QueryResult<string> { Value = _driver.FindElement(new SelectorMapper().Map(query.Selector)).Text };
        }
    }
}
