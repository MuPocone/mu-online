using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MuOnline.Infrastruture.Application.Core
{
    public interface IRepository
    {
        Task AddAsync<TEntity>(TEntity entity) where TEntity : Entity;
        Task AddEntityMuAsync<TEntity>(TEntity entity) where TEntity : class; 
        Task<IEnumerable<TEntity>> GetEntityMuByAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class;
        Task<int> CountMuByAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class;
        Task<TEntity> GetByAsync<TEntity>(int id) where TEntity : Entity;
        Task<TEntity> GetByAsync<TEntity>(Guid aggregateId) where TEntity : Entity;
        Task<TEntity> GetByAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : Entity; 
        Task<int> CountAsync<TEntity>(Expression<Func<TEntity, bool>> filter)
            where TEntity : Entity;  
        Task<bool> ExistAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : Entity;
    }
}