using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementTagNameQueryHandler : IQueryHandler<string, GetTagName>
    {
        private readonly IWebElement _element;

        public GetElementTagNameQueryHandler(IWebElement element)
        {
            _element = element;
        }
        public string Handle(IQuery<GetTagName> query)
        {
            return _element.TagName;
        }
    }
}
