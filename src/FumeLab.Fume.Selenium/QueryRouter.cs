﻿using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Commands;
using FumeLab.Fume.Core.Queries;
using FumeLab.Fume.Selenium.CommandHandlers;
using FumeLab.Fume.Selenium.QueryHandlers;
using OpenQA.Selenium;

namespace FumeLab.Fume.Selenium
{
    public class QueryRouter : IQueryHandler<IQueryResult, IQuery>
    {
        private readonly QueryHandlerFactory _queryFactory;
        private readonly IWebDriver _driver;

        public QueryRouter(QueryHandlerFactory queryFactory, IWebDriver driver)
        {
            _queryFactory = queryFactory;
            _driver = driver;

            //_queryFactory.Register<GetPage>(() => new GetPageQueryHandler(_driver, new PageFactory(new CommandRouter(new CommandHandlerFactory(), driver))));
            //_queryFactory.Register<FindElement>(() => new FindElementQueryHandler(_driver));

        }

        public IQueryResult Handle(IQuery query)
        {
            return _queryFactory.Create(query.GetType()).Handle(query);
        }
    }
}
