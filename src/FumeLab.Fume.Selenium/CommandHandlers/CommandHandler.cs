using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal abstract class CommandHandler<TCommand> : ICommandHandler<ICommand> where TCommand : ICommand
    {
        protected IQueryHandler<IWebElement, FindElement> Query { get; }

        protected CommandHandler(IQueryHandler<IWebElement, FindElement> query)
        {
            Query = query;
        }

        public void Handle(ICommand command)
        {
            HandleCommand((TCommand) command);
        }

        public abstract void HandleCommand(TCommand command);
    }
}
