using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ExamenContext : DbContext
    {
        public DbSet<Livreur> Livreurs { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Colis> Colis { get; set; }

        public DbSet<Vehicule> Vehicules { get; set; }

        public DbSet<Voiture> Voiture { get; set; }

        public DbSet<Camion> Camion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
               Initial Catalog=ExamenDB; 
               Integrated Security=true;
                MultipleActiveResultSets=true");   ///on va utilisé les paramètres d'auth windows

            //Active LazyLoading
            optionsBuilder.UseLazyLoadingProxies();


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            // 3 - a  - Configurer la clé primaire de la table porteuse de données (Colis)
            modelBuilder.Entity<Colis>()
                .HasKey(t => new { t.LivreurFK, t.ClientFK, t.DateLivraison });

            // 3 - b
            modelBuilder.Entity<Livreur>()
             .HasMany(c => c.Vehicules)
             .WithMany(s => s.Livreurs)
             .UsingEntity(j => j.ToTable("Conduite"));

            // 3 - c - configurer l'approche table par type(TPT)
            modelBuilder.Entity<Voiture>().ToTable("Voiture");
            modelBuilder.Entity<Camion>().ToTable("Camion");



            base.OnModelCreating(modelBuilder);
        }
    }
}
