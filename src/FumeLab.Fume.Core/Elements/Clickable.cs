using System;
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

        public void WaitUntilClickable(TimeSpan timeout) => _commandRouter.Handle(new WaitUntilClickable { Timeout = timeout, Selector = this.Selector });
        public void WaitUntilExists(TimeSpan timeout) => _commandRouter.Handle(new WaitUntilExists { Timeout = timeout, Selector = this.Selector });
        public void WaitUntilVisible(TimeSpan timeout) => _commandRouter.Handle(new WaitUntilVisible { Timeout = timeout, Selector = this.Selector });
    }
}
