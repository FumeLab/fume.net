﻿using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium.CommandHandlers
{
    internal class SetValueCommandHandler : CommandHandler<SetValue>
    {
        public SetValueCommandHandler(IQueryHandler<QueryResult<IWebElement>, FindElement> query) : base (query)
        {
        }

       public override void HandleCommand(SetValue command)
        {
            var element =
                Query.Execute(new FindElement { Selector = command.Selector }).Value;
            element.Clear();
            element.SendKeys(command.Value);
        }
    }
}
