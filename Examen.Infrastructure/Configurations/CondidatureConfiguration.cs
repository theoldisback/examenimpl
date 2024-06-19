using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class CondidatureConfiguration : IEntityTypeConfiguration<Candidature>
    {
        public void Configure(EntityTypeBuilder<Candidature> builder)
        {
            builder.HasOne(p => p.Enseignant).WithMany(p => p.Candidatures)
               .HasForeignKey(p => p.EnseignantFk);
            builder.HasOne(p => p.Concours).WithMany(p => p.Candidatures)
                .HasForeignKey(p => p.ConcoursFK);
            builder.HasKey(inv => new
            {
                inv.EnseignantFk,
                inv.ConcoursFK
            });
        }
    }
}
