using FumeLab.Fume.Core.Queries;

namespace FumeLab.Fume.Selenium
{
    public class QueryResult<T> : IQueryResult
    {
        public T Value { get; set; }
    }
}
