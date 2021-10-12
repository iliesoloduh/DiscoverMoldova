using DiscoverMoldova.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Infrastructure.EntityConfiguration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.DistrictId)
                   .IsRequired();
        }
    }
}
