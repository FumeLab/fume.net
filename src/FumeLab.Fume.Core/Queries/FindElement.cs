using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Queries
{
    public class FindElement : IQuery
    {
        public Selector Selector { get; set; }
    }
}
