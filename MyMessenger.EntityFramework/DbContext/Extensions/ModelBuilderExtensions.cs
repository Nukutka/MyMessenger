using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Entities;

namespace MyMessenger.EntityFramework.DbContext.Extensions
{
    public static class ModelBuilderExtensions
    {
        ///// <summary>
        ///// Pg does not set sequence value by seed..
        ///// </summary>
        //public static void SetSequence<TEntity>(this ModelBuilder modelBuilder, int idStartValue)
        //    where TEntity : Entity<Guid>
        //{
        //    var seqName = $"{typeof(TEntity).Name}_seq";

        //    modelBuilder.HasSequence<int>(seqName)
        //        .StartsAt(idStartValue)
        //        .IncrementsBy(1);

        //    modelBuilder.Entity<TEntity>()
        //        .Property(p => p.Id)
        //        .HasDefaultValueSql($"nextval('\"{seqName}\"')");
        //}
    }
}
