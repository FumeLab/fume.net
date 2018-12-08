using System;
using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;

namespace FumeLab.Fume.Selenium
{
    public interface ICommandHandlerFactory
    {
        void Register<T>(Func<ICommandHandler<ICommand>> handlerFunc) where T : ICommand;

        ICommandHandler<ICommand> Create(Type commandType);
    }
}
