namespace FumeLab.Fume.Core
{
    public interface IQueryHandler<TResponse, TQuery>
    {
        TResponse Handle(IQuery<TQuery> query);
    }
}
