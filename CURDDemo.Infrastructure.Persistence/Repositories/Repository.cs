using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence;
using CURDDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CURDDemo.Infrastructure.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DemoDbContext Context;
        private readonly DbSet<TEntity> _entities;

        public Repository(DemoDbContext dbContext)
        {
            Context = dbContext;
            _entities = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.SingleOrDefaultAsync(predicate);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _entities.AsNoTracking().ToListAsync();
        }

        public async Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task RemoveAsync(int id)
        {
            var reqEntity = await _entities.FindAsync(id);

            if (reqEntity == null)
                throw new Exception("Invalid Id.");

            _entities.Remove(reqEntity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var reqEntity = await _entities.FindAsync(entity.Id);

            if (reqEntity == null)
                throw new Exception("Invalid Id.");

            Context.Entry(reqEntity).CurrentValues.SetValues(entity);

            //_entities.Update(entity);
        }
    }
}
