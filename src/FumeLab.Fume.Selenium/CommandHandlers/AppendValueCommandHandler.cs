using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class AppendValueCommandHandler : CommandHandler<AppendValue>
    {
        public AppendValueCommandHandler(IQueryHandler<QueryResult<IWebElement>, FindElement> query) : base(query)
        {
        }

        public override void HandleCommand(AppendValue command)
        {
            Query.Handle(new FindElement { Selector = command.Selector }).Value.SendKeys(command.Value);
        }

    }
}
