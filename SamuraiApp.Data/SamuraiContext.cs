using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //definindo internamente qual database o ef.core irá usar (neste caso o MSSQL Server)
            optionsBuilder.UseSqlServer(@"Data Source=(local)\SERVER_XPS;Integrated Security=True;Database=SamuraiAppData;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

