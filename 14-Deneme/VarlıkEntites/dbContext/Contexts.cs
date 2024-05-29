using Deneme.VarlıkEntites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.VarlıkEntites.dbContext
{
    public class Contexts : DbContext
    {
        public DbSet<Tedarikci> Tedarikci {  get; set; }
        public DbSet<Urun> Urunler {  get; set; }
        public DbSet<Kategori> Kategoriler {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=IstkaTekrarDb;Trusted_Connection=true;TrustServerCertificate=true"); //database ismini ??

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
