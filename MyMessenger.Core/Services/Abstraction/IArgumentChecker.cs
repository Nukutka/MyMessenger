using System;
using Volo.Abp.DependencyInjection;

namespace MyMessenger.Core.Services.Abstraction
{
    public interface IArgumentChecker
    {
        /// <summary>
        /// If null return false
        /// </summary>
        bool CheckNullArgument<T>(T value) where T : class;

        /// <summary>
        /// If null throw exception with arg name
        /// </summary>
        void CheckNullArgument<T>(Func<T> argumentFunc) where T : class;
    }
}
