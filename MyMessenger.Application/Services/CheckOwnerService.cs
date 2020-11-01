using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Services.Abstraction;
using MyMessenger.Domain.Shared.Interfaces;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MyMessenger.Application.Services
{
    public class CheckOwnerService : BaseService
    {
        public async Task CheckOwnerAndThrowAsync<TEntity>(Guid id, Guid userId)
            where TEntity : Entity<Guid>, IOwnedEntity
        {
            var repository = GetRepository<TEntity>();

            var check = await repository.AnyAsync(e => e.Id == id && e.UserId == userId);

            if (!check) ExceptionManager.EntityNotFound();
        }

        public async Task<bool> CheckOwnerAsync<TEntity>(Guid id, Guid userId)
            where TEntity : Entity<Guid>, IOwnedEntity
        {
            var repository = GetRepository<TEntity>();

            var check = await repository.AnyAsync(e => e.Id == id && e.UserId == userId);

            return check;
        }

        public async Task<TEntity> CheckOwnerAndGetAsync<TEntity>(Guid id, Guid userId)
            where TEntity : Entity<Guid>, IOwnedEntity
        {
            var repository = GetRepository<TEntity>();

            var entity = await repository.AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id && e.UserId == userId);

            return entity;
        }
    }
}
