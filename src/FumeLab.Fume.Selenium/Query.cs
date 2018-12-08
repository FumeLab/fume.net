using FumeLab.Fume.Core;

namespace FumeLab.Fume.Selenium
{
    public class Query<TQuery> : IQuery<TQuery>
    {
        public TQuery Value { get; }

        public Query(TQuery value)
        {
            Value = value;
        }
    }
}
