using System;
using System.Linq.Expressions;

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
        void CheckNullArgument<T>(Expression<Func<T>> argumentFunc) where T : class;
    }
}
