using System;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core.Elements
{
    public class Input : Element
    {
        private readonly ICommandRouter _commandRouter;

        public Input(Selector selector, ICommandRouter commandRouter) : base(selector)
        {
            _commandRouter = commandRouter;
        }

        public void SetValue(string value) => _commandRouter.Route(new SetValue { Selector = this.Selector, Value = value });

        public void AppendValue(string value) => _commandRouter.Route(new AppendValue { Selector = this.Selector, Value = value });

        public void ClearValue() => _commandRouter.Route(new ClearValue { Selector = this.Selector });

        public void WaitUntilVisible(TimeSpan timeout) => _commandRouter.Route(new WaitUntilVisible {Timeout = timeout, Selector = this.Selector});
    }
}