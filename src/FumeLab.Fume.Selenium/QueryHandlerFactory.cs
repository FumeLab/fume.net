using System;
using System.Collections.Generic;
using FumeLab.Fume.Core;
using FumeLab.Fume.Core.Queries;

namespace FumeLab.Fume.Selenium
{
    public class QueryHandlerFactory
    {
        private readonly Dictionary<Type, Func<IQueryHandler<IQueryResult, IQuery>>> _queryHandlers =
            new Dictionary<Type, Func<IQueryHandler<IQueryResult, IQuery>>>();

        public void Register<T>(Func<IQueryHandler<IQueryResult, IQuery>> handlerFunc) where T : IQuery
        {
            _queryHandlers.Add(typeof(T), handlerFunc);
        }

        public IQueryHandler<IQueryResult, IQuery> Create(Type commandType)
        {
            return _queryHandlers[commandType].Invoke();
        }
    }
}
