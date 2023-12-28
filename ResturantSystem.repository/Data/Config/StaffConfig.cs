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
    internal class StaffConfig : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.Property(S => S.Name).IsRequired().HasMaxLength(100);
            builder.Property(S => S.Salary).IsRequired().HasColumnType("decimal (18 , 2)");
            builder.Property(S => S.Position).IsRequired().HasMaxLength(100);
            builder.HasOne(S => S.Resturant)
               .WithMany()
               .HasForeignKey(P => P.ResturantId);
        }
    }
}
