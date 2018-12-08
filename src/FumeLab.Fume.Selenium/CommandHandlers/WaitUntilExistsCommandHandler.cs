using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Selenium.QueryHandlers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class WaitUntilExistsCommandHandler : CommandHandler<WaitUntilExists>
    {
        private readonly IWebDriver _driver;

        public WaitUntilExistsCommandHandler(IWebDriver driver) : base(new FindElementQueryHandler(driver))
        {
            _driver = driver;
        }

        public override void HandleCommand(WaitUntilExists command)
        {
            var selectorMapper = new SelectorMapper();
            new WebDriverWait(_driver, command.Timeout).Until((driver) => driver.FindElement(selectorMapper.Map(command.Selector)).TagName != null);
        }
    }
}
