
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {

        public DbSet<Candidature> candidatures { get; set; }
        public DbSet<Concours> concours { get; set; }
        public DbSet<Enseignant> Enseignants { get; set; }

        public DbSet<UP> uPs { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= Examenconcours;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConcoursConfiguration());
            modelBuilder.ApplyConfiguration(new CondidatureConfiguration());
            modelBuilder.ApplyConfiguration(new EnseignantConfiguration());
            modelBuilder.ApplyConfiguration(new UpConfiguration());








        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }
    }
}
