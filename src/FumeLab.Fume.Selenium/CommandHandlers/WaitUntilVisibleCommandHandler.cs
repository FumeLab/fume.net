using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Selenium.QueryHandlers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class WaitUntilVisibleCommandHandler : CommandHandler<WaitUntilVisible>
    {
        private readonly IWebDriver _driver;

        public WaitUntilVisibleCommandHandler(IWebDriver driver) : base(new FindElementQueryHandler(driver))
        {
            _driver = driver;
        }

        public override void HandleCommand(WaitUntilVisible command)
        {
            var selectorMapper = new SelectorMapper();
            new WebDriverWait(_driver, command.Timeout).Until((driver) => driver.FindElement(selectorMapper.Map(command.Selector)).Displayed);
        }
    }
}
