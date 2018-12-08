using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetPageQueryHandler<TPage> : IQueryHandler<QueryResult<TPage>, GetPage> where TPage : class, new()
    {
        private readonly IWebDriver _driver;
        private readonly IPageFactory _pageFactory;

        public GetPageQueryHandler(IWebDriver driver, IPageFactory pageFactory)
        {
            _driver = driver;
            _pageFactory = pageFactory;
        }
        public QueryResult<TPage> Handle(GetPage query)
        {
            _driver.Navigate().GoToUrl(query.Url);

            return new QueryResult<TPage> {Value = _pageFactory.CreatePage<TPage>()};
        }

    }
}
