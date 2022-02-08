using Business.Entities;
using DataAccess.Context;
using DataAccess.Repository.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(DataContext context, ILogger logger) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<Brand>> All()
        {
            return await _dbSet.Where(c => c.IsDeleted == false).ToListAsync();
        }
    }
}
