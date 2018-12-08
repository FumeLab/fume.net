using FumeLab.Fume.Core.Queries;

namespace FumeLab.Fume.Core
{
    public interface IQueryHandler<TResponse, TQuery> 
        where TResponse : IQueryResult
        where TQuery : IQuery
    {
        TResponse Execute(TQuery query);
    }
}
