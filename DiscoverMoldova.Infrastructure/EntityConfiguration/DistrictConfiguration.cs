using DiscoverMoldova.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Infrastructure.EntityConfiguration
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
