using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class IsElementCheckedQueryHandler : IQueryHandler<bool, IsChecked>
    {
        private readonly IWebElement _element;

        public IsElementCheckedQueryHandler(IWebElement element)
        {
            _element = element;
        }
        public bool Handle(IQuery<IsChecked> query)
        {
            return _element.Selected;
        }
    }
}
