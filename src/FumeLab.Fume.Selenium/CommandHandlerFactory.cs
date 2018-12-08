using System;
using System.Collections.Generic;
using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;

namespace FumeLab.Fume.Selenium
{
    public class CommandHandlerFactory : ICommandHandlerFactory
    {
        private readonly Dictionary<Type, Func<ICommandHandler<ICommand>>> _commandHandlers = new Dictionary<Type, Func<ICommandHandler<ICommand>>>();

        public void Register<T>(Func<ICommandHandler<ICommand>> handlerFunc) where T : ICommand
        {
            _commandHandlers.Add(typeof(T), handlerFunc);
        }

        public ICommandHandler<ICommand> Create(Type commandType)
        {
            return _commandHandlers[commandType].Invoke();
        }
    }
}
