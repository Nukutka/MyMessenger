using MyMessenger.Core.Services.Abstraction;
using System;
using System.Linq.Expressions;

namespace MyMessenger.Core.Services
{
    public class ArgumentChecker : IArgumentChecker
    {
        private readonly IExceptionManager exceptionManager;

        public ArgumentChecker(IExceptionManager exceptionManager)
        {
            this.exceptionManager = exceptionManager;
        }

        // TODO: use CallerArgumentExpressionAttribute

        /// <summary>
        /// If null return false
        /// </summary>
        public bool CheckNullArgument<T>(T value)
            where T : class
        {
            if (value is null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// If null throw exception with arg name
        /// </summary>
        public void CheckNullArgument<T>(Expression<Func<T>> argumentFunc)
            where T : class
        {
            var value = argumentFunc.Compile().Invoke();

            if (value is null)
            {
                var name = ((MemberExpression)argumentFunc.Body).Member.Name;
                exceptionManager.NullArgument(name);
            }
        }
    }
}
