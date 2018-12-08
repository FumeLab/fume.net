using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Selenium.CommandHandlers;
using FumeLab.Fume.Selenium.QueryHandlers;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium
{
    public class CommandRouter : ICommandRouter
    {
        private readonly ICommandHandlerFactory _commandFactory;
        private readonly IWebDriver _driver;
        
        public CommandRouter(ICommandHandlerFactory commandFactory, IWebDriver driver)
        {
            _commandFactory = commandFactory;
            _driver = driver;

            _commandFactory.Register<Click>(() => new ClickCommandHandler(new FindElementQueryHandler(_driver)));
            _commandFactory.Register<SetValue>(() => new SetValueCommandHandler(new FindElementQueryHandler(_driver)));
            _commandFactory.Register<AppendValue>(() => new AppendValueCommandHandler(new FindElementQueryHandler(_driver)));
            _commandFactory.Register<ClearValue>(() => new ClearValueCommandHandler(new FindElementQueryHandler(_driver)));

        }
        public void Route(ICommand command)
        {
            _commandFactory.Create(command.GetType()).Handle(command);
        }
    }
}
