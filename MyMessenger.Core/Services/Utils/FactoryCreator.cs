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
            var factory = Activator.CreateInstance(typeof(TFactory)) as TFactory;

            return factory;
        }
    }
}
