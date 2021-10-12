using DiscoverMoldova.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Infrastructure.EntityConfiguration
{
    public class FacilityConfiguration : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
