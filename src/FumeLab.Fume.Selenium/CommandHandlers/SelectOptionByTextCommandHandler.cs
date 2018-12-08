using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class SelectOptionByTextCommandHandler : CommandHandler<SelectByText>
    {
        public SelectOptionByTextCommandHandler(IQueryHandler<QueryResult<IWebElement>, FindElement> query) : base(query)
        {
        }

        public override void HandleCommand(SelectByText command)
        {
            var element = Query.Execute(new FindElement {Selector = command.Selector}).Value;
            new SelectElement(element).SelectByText(command.Text);
        }
    }
}
