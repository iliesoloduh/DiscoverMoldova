using DiscoverMoldova.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Infrastructure.EntityConfiguration
{
    public class ResortConfiguration : IEntityTypeConfiguration<Resort>
    {
        public void Configure(EntityTypeBuilder<Resort> builder)
        {
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Address)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Phone)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(x => x.Price)
                   .IsRequired();

            builder.Property(x => x.Capacity)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .IsRequired();

            builder.Property(x => x.UserId)
                   .IsRequired();

            builder.Property(x => x.LocationId)
                   .IsRequired();
        }
    }
}
