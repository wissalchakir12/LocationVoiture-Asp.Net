using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Auth> Auths { get; set; }
        protected override void OnConfiguring
     (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=localhost\SQLEXPRESS;Initial Catalog=CarDatabase;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }
}
