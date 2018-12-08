using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementTextQueryHandler : IQueryHandler<string, GetText>
    {
        private readonly IWebElement _element;

        public GetElementTextQueryHandler(IWebElement element)
        {
            _element = element;
        }
        public string Handle(IQuery<GetText> query)
        {
            return _element.Text;
        }
    }
}
