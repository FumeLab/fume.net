using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.QueryHandlers
{
    public class GetElementAttributeQueryHandler : IQueryHandler<QueryResult<string>, GetAttribute>
    {
        private readonly IWebElement _element;

        public GetElementAttributeQueryHandler(IWebElement element)
        {
            _element = element;
        }
        public QueryResult<string> Execute(GetAttribute query)
        {
            return new QueryResult<string> {Value = _element.GetAttribute(query.Attribute)};
        }
    }
}
