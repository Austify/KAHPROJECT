using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KAHPROJECT.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> User { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

    }
}
