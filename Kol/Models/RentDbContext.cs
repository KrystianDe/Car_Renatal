using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol.Models
{
    public class RentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16891;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}
