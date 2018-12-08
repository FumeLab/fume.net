using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class ClickCommandHandler : CommandHandler<Click>
    {
        public ClickCommandHandler(IQueryHandler<QueryResult<IWebElement>, FindElement> query) : base (query)
        {
        }

        public override void HandleCommand(Click command)
        {
            Query.Execute(new FindElement {Selector = command.Selector}).Value.Click();
        }
    }
}
