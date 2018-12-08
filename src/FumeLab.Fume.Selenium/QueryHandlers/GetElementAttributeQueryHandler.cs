using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementAttributeQueryHandler : IQueryHandler<string, GetAttribute>
    {
        private readonly IWebElement _element;

        public GetElementAttributeQueryHandler(IWebElement element)
        {
            _element = element;
        }
        public string Handle(IQuery<GetAttribute> query)
        {
            return _element.GetAttribute(query.Value.Attribute);
        }
    }
}
