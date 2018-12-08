using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace FumeLab.Fume.Selenium
{
    public class DriverProvider
    {
        public static IWebDriver GetDriver()
        {
            IWebDriver _driver = new RemoteWebDriver(new DesiredCapabilities());
            return _driver;
        }
}
}
