using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.dbContext
{
    public class EmployeeDbContext:IdentityDbContext<ApplicationUser>
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options ):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
