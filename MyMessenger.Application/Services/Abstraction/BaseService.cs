using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyMessenger.Core.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace MyMessenger.Application.Services.Abstraction
{
    public abstract class BaseService : ApplicationService
    {
        private IArgumentChecker argumentChecker;
        protected IArgumentChecker ArgumentChecker => LazyGetRequiredService(ref argumentChecker);

        private IExceptionManager exceptionManager;
        protected IExceptionManager ExceptionManager => LazyGetRequiredService(ref exceptionManager);

        #region Bulk

        // TODO: replace this shit with real Bulk insert
        protected async Task BulkInsertAsync<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : Entity<Guid>
        {
            var repository = GetRepository<TEntity>();

            // :D
            foreach (var entity in entities)
            {
                await repository.InsertAsync(entity);
            }
        }

        protected async Task BulkDeleteAsync<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : Entity<Guid>
        {
            var repository = GetRepository<TEntity>();

            foreach (var entity in entities)
            {
                await repository.DeleteAsync(entity);
            }
        }

        #endregion

        /// <summary>
        /// Check exists entity and throw not found
        /// </summary>
        protected async Task CheckExistsEntity<TEntity>(Guid id)
            where TEntity : Entity<Guid>
        {
            var repository = GetRepository<TEntity>();

            var check = await repository.AnyAsync(e => e.Id == id);

            if (!check) ExceptionManager.NotFound();
        }

        protected IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : Entity<Guid>
        {
            return ServiceProvider.GetRequiredService<IRepository<TEntity>>();
        }
    }
}
