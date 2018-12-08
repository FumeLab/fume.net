using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Elements
{
    public class Clickable : Element
    {
        private readonly ICommandHandler<ICommand> _commandRouter;

        public Clickable(Selector selector, ICommandHandler<ICommand> commandRouter) : base(selector)
        {
            _commandRouter = commandRouter;
        }

        public void Click() => _commandRouter.Handle(new Click {Selector = this.Selector});
    }
}
