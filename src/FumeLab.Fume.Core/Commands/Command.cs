using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Commands
{
    public abstract class Command : ICommand
    {
        public Selector Selector { get; set; }
    }
}
