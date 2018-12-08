using System;
using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;
using FumeLab.Fume.Selenium;
using FumeLab.Fume.Selenium.QueryHandlers;
using FumeLab.Fume.Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace FumeLab.Fume.Tests
{
    public sealed class Hackathon2018
    {

        [Test]
        public void SearchFumeTest()

        {
            TimeSpan timeout = TimeSpan.FromSeconds(5);

            //base url
            var url = "https://github.com/";
            var driver = new ChromeDriver();
            var commandRouter = new CommandRouter(new CommandHandlerFactory(), driver);
            var pageFactory = new PageFactory(commandRouter);
            var gitHubPageQueryHandler = new GetPageQueryHandler<GitHubPage>(driver, pageFactory);

            var githubPage = gitHubPageQueryHandler.Handle(new Query<GetPage>(new GetPage { Url = url }));

            //SeleniumDriver.WebDriver.Manage().Window.Maximize();



            //search for FumeLab on GitHub
            githubPage.SearchGitHub.WaitUntilVisible(timeout);
            githubPage.SearchGitHub.SetValue("FumeLab");
            githubPage.JumpToFume.WaitUntilClickable(timeout);
            githubPage.JumpToFume.Click();

            ////select FumeLab
            githubPage.FumeLabLink.WaitUntilExists(timeout);
            githubPage.FumeLabLink.Click();

            ////select FumeLabBase
            githubPage.FumeLabBaseLink.WaitUntilClickable(timeout);
            githubPage.FumeLabBaseLink.Click();

            ////go to Fume Website
            githubPage.FumeSiteLink.WaitUntilVisible(timeout);
            githubPage.FumeSiteLink.Click();

            //Assert.Equals("Fume Lab", SeleniumDriver.WebDriver.Title);


        }

    }
}