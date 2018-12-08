using FumeLab.Fume.Core;

namespace FumeLab.Fume.Selenium
{
    public class QueryRouter<TResponse, TQuery> : IQueryHandler<TResponse, TQuery>
    {
        public TResponse Handle(IQuery<TQuery> query)
        {
            throw new System.NotImplementedException();
        }
    }
}
