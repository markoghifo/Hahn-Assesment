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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context, ILogger logger) : base(context, logger)
        {

        }

        public override async Task<bool> Upsert(Product entity)
        {
            var existingProd = await GetById(entity.Id);
            //_dbSet.Where(p => p.Id == entity.Id).FirstOrDefaultAsync();
            if (existingProd == null)
            {
                //return await Add(entity);

                return false;
            }
            else
            {
                existingProd.Quantity += entity.Quantity;
                existingProd.UnitsInStock += entity.Quantity;
                existingProd.IsAvailable = entity.IsAvailable;
                existingProd.Description = entity.Description;
                existingProd.LastUpdateDate = DateTime.Now;
                existingProd.LastUpdatedBy = string.IsNullOrEmpty(entity.LastUpdatedBy) ? "" : entity.LastUpdatedBy;
                existingProd.Features = entity.Features;

                return true;
            }
        }

        public async Task<IEnumerable<Product>> AllAvailable()
        {
            return await _dbSet.Where(p => p.IsAvailable).ToListAsync();
        }

        public async Task<IEnumerable<Product>> AllDeleted()
        {
            return await _dbSet.Where(p => p.IsDeleted).ToListAsync();
        }
    }
}
