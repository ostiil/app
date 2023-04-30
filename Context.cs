using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Context : DbContext
    {
        public Context() 
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = BuscoSexo\\SQLEXPRESS; Database=Airlines; Integrated Security = True; TrustServerCertificate=True");
        }
    }

    
}
