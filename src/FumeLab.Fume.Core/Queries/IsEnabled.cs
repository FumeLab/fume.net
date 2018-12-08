using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Queries
{
    public class IsEnabled : IQuery
    {
        public Selector Selector { get; set; }
    }
}
