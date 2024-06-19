using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Infrastructure.Configurations
{
    public class EnseignantConfiguration : IEntityTypeConfiguration<Enseignant>
    {
        public void Configure(EntityTypeBuilder<Enseignant> builder)
        {
            builder.HasKey(inv => new
            {
                inv.Matricule
            });
        }
    }
}
