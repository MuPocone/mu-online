using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MuOnline.Infrastruture.Application.Core;

namespace MuOnline.EF
{
    public class Repository : IRepository
    {
        private readonly MuContext _dbContext;

        public Repository(MuContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task AddAsync<TEntity>(TEntity entity) where TEntity : Entity
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddEntityMuAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetEntityMuByAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            return await _dbContext.Set<TEntity>().Where(filter).ToListAsync(); 
        } 

        public async Task<int> CountMuByAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            return await _dbContext.Set<TEntity>().CountAsync(filter);
        }

        public async Task<TEntity> GetByAsync<TEntity>(int id) where TEntity : Entity
        {
            var entity = _dbContext.Set<TEntity>().Local.SingleOrDefault(e => e.Id == id);
            return entity ?? await _dbContext.Set<TEntity>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<TEntity> GetByAsync<TEntity>(Guid aggregateId) where TEntity : Entity
        {
            var entity = _dbContext.Set<TEntity>().Local.SingleOrDefault(e => e.AggregateId == aggregateId);
            return entity ?? await _dbContext.Set<TEntity>().SingleOrDefaultAsync(e => e.AggregateId == aggregateId);
        }

        public async Task<TEntity> GetByAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : Entity
        {
            return await _dbContext.Set<TEntity>().SingleOrDefaultAsync(filter);
        }

        public async Task<int> CountAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : Entity
        {
            return await _dbContext.Set<TEntity>().CountAsync(filter);
        }

        public async Task<bool> ExistAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : Entity
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().AnyAsync(filter);
        }
    }
}