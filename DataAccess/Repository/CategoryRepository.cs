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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataContext context, ILogger logger) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<Category>> All()
        {
            return await _dbSet.Where(c => c.IsDeleted == false).ToListAsync();
        }
    }
}
