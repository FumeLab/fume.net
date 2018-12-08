using System;
using System.Collections.Generic;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Elements;
using FumeLab.Fume.Core.Selectors;

namespace FumeLab.Fume.Core
{
    public class ElementFactory
    {
        private static readonly Dictionary<Type, Func<Selector, ICommandHandler<ICommand>, Element>> SupportedTypesCatalogue =
            new Dictionary<Type, Func<Selector, ICommandHandler<ICommand>, Element>>();

        static ElementFactory()
        {
            SupportedTypesCatalogue.Add(typeof(Clickable), (selector, commandRouter) => new Clickable(selector, commandRouter));
            SupportedTypesCatalogue.Add(typeof(Input), (selector, commandRouter) => new Input(selector, commandRouter));
        }

        public Element Create(Type elemenType, Selector selector, ICommandHandler<ICommand> commandRouter)
        {
            return SupportedTypesCatalogue[elemenType].Invoke(selector, commandRouter);
        }
    }
}
