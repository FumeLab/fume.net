using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Selenium.QueryHandlers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class WaitUntilClickableCommandHandler : CommandHandler<WaitUntilClickable>
    {
        private readonly IWebDriver _driver;

        public WaitUntilClickableCommandHandler(IWebDriver driver) : base(new FindElementQueryHandler(driver))
        {
            _driver = driver;
        }

        public override void HandleCommand(WaitUntilClickable command)
        {
            var selectorMapper = new SelectorMapper();
            new WebDriverWait(_driver, command.Timeout).Until((driver) => driver.FindElement(selectorMapper.Map(command.Selector)).Enabled);
        }
    }
}
