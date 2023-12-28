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
    internal class TableConfig : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.Property(T => T.Number).IsRequired().HasAnnotation("Range", new[] { 1, 40 });
            builder.Property(T => T.Capacity).IsRequired().HasAnnotation("Range", new[] { 1, 8 });
            builder.HasOne(T => T.Resturant)
               .WithMany()
               .HasForeignKey(T => T.ResturantId);
        }
    }
}
