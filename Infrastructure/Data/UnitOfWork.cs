using Business.Data.Abstract;
using Business.Interfaces.Repositories;
using DataAccess.Context;
using DataAccess.Repository;
using DataAccess.Repository.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataContext _context;
        private readonly ILogger _logger;
        public IProductRepository Products { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public IBrandRepository Brands { get; private set; }

        public UnitOfWork(DataContext context, ILoggerFactory loggerFactory = null)
        {
            _context = context;
            _logger = loggerFactory?.CreateLogger<UnitOfWork>();

            Products = new ProductRepository(_context, _logger);
            Categories = new CategoryRepository(_context, _logger);
            Brands = new BrandRepository(_context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
