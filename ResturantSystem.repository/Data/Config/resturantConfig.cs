using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantSystem.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem.repository.Data.Config
{
    internal class resturantConfig : IEntityTypeConfiguration<Resturant>
    {
        public void Configure(EntityTypeBuilder<Resturant> builder)
        {
            builder.Property(S => S.Name).IsRequired().HasMaxLength(100);
            builder.Property(S => S.phone).IsRequired().HasMaxLength(11);
        }
    }
}
