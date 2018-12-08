using FumeLab.Fume.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementSelectedOptionValue : IQueryHandler<string, GetElementSelectedOptionValue>
    {
        private readonly IWebElement _element;

        public GetElementSelectedOptionValue(IWebElement element)
        {
            _element = element;
        }
        public string Handle(IQuery<GetElementSelectedOptionValue> query)
        {
            return new SelectElement(_element).SelectedOption.GetAttribute("value");
        }
    }
}
