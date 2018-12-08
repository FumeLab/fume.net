using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class SelectOptionByValueCommandHandler : CommandHandler<SelectByValue>
    {
        public SelectOptionByValueCommandHandler(IQueryHandler<QueryResult<IWebElement>, FindElement> query) : base(query)
        {
        }

        public override void HandleCommand(SelectByValue command)
        {
            var element = Query.Execute(new FindElement { Selector = command.Selector }).Value;
            new SelectElement(element).SelectByValue(command.Value);
        }
    }
}
