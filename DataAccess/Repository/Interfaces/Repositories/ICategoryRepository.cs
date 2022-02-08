using Business.Entities;
using Business.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces.Repositories
{

    public interface ICategoryRepository : IGenericRepository<Category>
    {
        //declare entity specific methods ....

    }
}
