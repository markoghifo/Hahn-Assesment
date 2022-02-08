using Business.Entities;
using Business.Interfaces.Repositories;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityAuditableModel //class
    {
        protected DataContext _context;
        protected DbSet<T> _dbSet;
        protected readonly ILogger _logger;

        public GenericRepository(DataContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _dbSet = _context.Set<T>();
        }

        public async virtual Task<bool> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public async virtual Task<IEnumerable<T>> All()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> AllDeleted()
        {
            return await _dbSet.Where(e => e.IsDeleted).ToListAsync();
        }

        public virtual async Task<bool> Delete(int id)
        {
            //_context.Set<T>().Remove(entity);
            var existing = await GetById(id);
            if (existing == null)
            {
                return false;
            }
            else
            {
                existing.IsDeleted = true;
                existing.DeletedBy = ""; //pass user id
                return true;
            }
        }

        public async virtual Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Upsert(T entity)
        {
            var existing = await GetById(entity.Id);
            if (existing == null)
            {
                //return await Add(entity);

                return false;
            }
            else
            {
                existing.LastUpdateDate = DateTime.Now;
                existing.LastUpdatedBy = string.IsNullOrEmpty(entity.LastUpdatedBy) ? "" : entity.LastUpdatedBy;

                return true;
            }
        }
    }
}
