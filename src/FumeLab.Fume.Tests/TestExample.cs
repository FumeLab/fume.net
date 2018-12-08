using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using FumeLab.Fume.Selenium;
using FumeLab.Fume.Selenium.QueryHandlers;
using FumeLab.Fume.Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace FumeLab.Fume.Tests
{
    public class TestExample
    {
        [Test]
        public void TestWaitUntilNotClickable()
        {
            var url = "https://www.ultimateqa.com/simple-html-elements-for-automation/";
            var driver = new ChromeDriver();
            var commandRouter = new CommandRouter(new CommandHandlerFactory(), driver);
            var queryHandler = new GetPageQueryHandler<PageExample>(driver, new PageFactory(commandRouter));

            var page = queryHandler.Execute(new GetPage {Url = url});
            //page.inputElement.SetValue("zdravozivo");
            page.Value.ClickMeButton.Click();
        }

    }
}
