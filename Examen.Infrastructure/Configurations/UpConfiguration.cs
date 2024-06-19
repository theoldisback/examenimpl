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
    public class UpConfiguration : IEntityTypeConfiguration<UP>
    {
        public void Configure(EntityTypeBuilder<UP> builder)
        {
            builder.HasKey(inv => new
            {
                inv.Code
            });
        }
    }
}
