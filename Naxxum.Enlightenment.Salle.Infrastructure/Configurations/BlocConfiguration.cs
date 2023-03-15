using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.Infrastructure.Configurations;
public class BlocConfiguration : IEntityTypeConfiguration<Bloc>
{
    public void Configure(EntityTypeBuilder<Bloc> builder)
    {
        // Configure the ID property
        builder.HasKey(e => e.IdBloc);

        // Optional: configure the name of the ID property
        builder.Property(e => e.IdBloc)
             .HasColumnName("IdBloc");
    }
}
