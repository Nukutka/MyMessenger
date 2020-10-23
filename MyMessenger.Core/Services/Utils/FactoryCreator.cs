using MyMessenger.Core.Factories.Abstraction;
using System;

namespace MyMessenger.Core.Services.Utils
{
    /// <summary>
    /// Use this class only for static classes like data seeds, etc
    /// </summary>
    public static class FactoryCreator 
    {
        public static TFactory GetFactory<TFactory>()
            where TFactory : BaseFactory
        {
            var exceptionManager = new ExceptionManager();
            var argumentChecker = new ArgumentChecker(exceptionManager);
            var factory = Activator.CreateInstance(typeof(TFactory), argumentChecker) as TFactory;

            return factory;
        }
    }
}
