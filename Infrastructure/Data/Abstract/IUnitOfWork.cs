using Business.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data.Abstract
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        Task CompleteAsync();
    }
}
