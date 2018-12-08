using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Selenium.CommandHandlers;
using FumeLab.Fume.Selenium.QueryHandlers;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium
{
    public class CommandRouter : ICommandHandler<ICommand>
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
            _commandFactory.Register<SelectByText>(() => new SelectOptionByTextCommandHandler(new FindElementQueryHandler(_driver)));
            _commandFactory.Register<SelectByValue>(() => new SelectOptionByValueCommandHandler(new FindElementQueryHandler(_driver)));
            _commandFactory.Register<WaitUntilVisible>(() => new WaitUntilVisibleCommandHandler(_driver));
            _commandFactory.Register<WaitUntilClickable>(() => new WaitUntilClickableCommandHandler(_driver));
            _commandFactory.Register<WaitUntilExists>(() => new WaitUntilExistsCommandHandler(_driver));

        }
        public void Handle(ICommand command)
        {
            _commandFactory.Create(command.GetType()).Handle(command);
        }
    }
}
