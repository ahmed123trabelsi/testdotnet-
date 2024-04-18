
using Examen.ApplicationCore.Domain;
using Examen.Infra.Configuartion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infra
{
    public class Context : DbContext
    {
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Option> options { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bungalow> bungalows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Initial Catalog=testTrabelsiAhmed;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
         


        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .Properties<string>()
                .HaveMaxLength(150);
        }

    }
    
}