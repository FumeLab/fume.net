using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Elements
{
    public class Clickable : Element
    {
        private readonly ICommandRouter _commandRouter;

        public Clickable(Selector selector, ICommandRouter commandRouter) : base(selector)
        {
            _commandRouter = commandRouter;
        }

        public void Click() => _commandRouter.Route(new Click {Selector = this.Selector});
    }
}
