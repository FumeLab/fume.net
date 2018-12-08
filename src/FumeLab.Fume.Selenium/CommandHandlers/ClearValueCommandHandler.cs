using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class ClearValueCommandHandler : CommandHandler<ClearValue>
    {
        public ClearValueCommandHandler(IQueryHandler<IWebElement, FindElement> query) : base(query)
        {
        }

        public override void HandleCommand(ClearValue command)
        {
            Query.Handle(new Query<FindElement>(new FindElement { Selector = command.Selector })).Clear();
        }
    }
}
