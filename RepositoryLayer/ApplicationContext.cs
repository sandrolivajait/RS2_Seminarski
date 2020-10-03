

using System;

using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model.Database;

namespace RepositoryLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<BannedKupac> BannedKupci { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Komentar> Komentari { get; set; }
        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Mobiteli> Mobiteli { get; set; }
        public DbSet<Narudzba> Narudzbe { get; set; }
        public DbSet<OperativniSustav> OperativniSustavi { get; set; }
        public DbSet<Popusti> Popusti { get; set; }
        public DbSet<Proizvodjac> Proizvodjaci { get; set; }
        public DbSet<SmsLog> SmsLog { get; set; }
        public DbSet<StavkaNarudzbe> StavkeNarudzbe { get; set; }

        public DbSet<Zupanija> Zupanije { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict; 
            }
            // seed initial db with data.
            SeedDb.Make(modelBuilder);
            }
    }
}
