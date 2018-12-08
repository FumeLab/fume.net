using System;
using System.Linq;
using System.Reflection;

namespace FumeLab.Fume.Core
{
    public class PageFactory : IPageFactory
    {
        private readonly ICommandRouter _commandRouter;

        public PageFactory(ICommandRouter commandRouter)
        {
            _commandRouter = commandRouter;
        }

        public T CreatePage<T>() where T : class, new()
        {
            var page = new T();
            var elementFactory = new ElementFactory();
            var selectorFactory = new SelectorFactory();

            var propertiesWithAttribute = typeof(T).GetProperties()
                .Where(item => item.GetCustomAttribute<SelectorAttribute>() != null);

            foreach (PropertyInfo propertyInfo in propertiesWithAttribute)
            {
                var selector = selectorFactory.Create(propertyInfo.GetCustomAttribute<SelectorAttribute>().Type,
                    propertyInfo.GetCustomAttribute<SelectorAttribute>().Value);
                propertyInfo.SetValue(page, elementFactory.Create(propertyInfo.PropertyType, selector, _commandRouter));
            }

            return page;
        }
    }
}
