using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Queries
{
    public class GetText : IQuery
    {
        public Selector Selector { get; set; }
    }
}
