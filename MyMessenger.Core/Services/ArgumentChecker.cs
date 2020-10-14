using MyMessenger.Domain.Shared.Constants;
using System;
using System.Linq;
using System.Reflection;
using Volo.Abp.DependencyInjection;

namespace MyMessenger.Core.Services
{
    public class ArgumentChecker : ISingletonDependency
    {
        private readonly ExceptionManager exceptionManager;

        public ArgumentChecker(ExceptionManager exceptionManager)
        {
            this.exceptionManager = exceptionManager;
        }

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
        public void CheckNullArgument<T>(Func<T> argumentFunc)
            where T : class
        {
            T value = argumentFunc();

            if (value is null)
            {
                var name = argumentFunc.Method
                    .ReflectedType
                    .GetRuntimeFields()
                    .First()
                    .Name;

                exceptionManager.Friendly($"{name}: {ExceptionMessages.NullArgument}");
            }
        }
    }
}
