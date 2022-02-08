using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AuthenticationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
    : base(options)
        {
        }
    }
}
