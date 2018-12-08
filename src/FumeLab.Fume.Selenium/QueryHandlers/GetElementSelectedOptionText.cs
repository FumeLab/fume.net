using FumeLab.Fume.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementSelectedOptionText : IQueryHandler<string, GetElementSelectedOptionText>
    {
        private readonly IWebElement _element;

        public GetElementSelectedOptionText(IWebElement element)
        {
            _element = element;
        }
        public string Handle(IQuery<GetElementSelectedOptionText> query)
        {
            return new SelectElement(_element).SelectedOption.Text;
        }
    }
}
