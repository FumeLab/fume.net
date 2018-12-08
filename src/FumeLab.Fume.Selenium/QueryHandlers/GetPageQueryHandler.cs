using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetPageQueryHandler<TPage> : IQueryHandler<TPage, GetPage> where TPage : class, new()
    {
        private readonly IWebDriver _driver;
        private readonly IPageFactory _pageFactory;

        public GetPageQueryHandler(IWebDriver driver, IPageFactory pageFactory)
        {
            _driver = driver;
            _pageFactory = pageFactory;
        }
        public TPage Handle(IQuery<GetPage> query)
        {
            _driver.Navigate().GoToUrl(query.Value.Url);
            _driver.Manage().Window.Maximize();
            return _pageFactory.CreatePage<TPage>();
        }

    }
}
