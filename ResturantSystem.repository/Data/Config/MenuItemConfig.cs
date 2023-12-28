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
    internal class MenuItemConfig : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.Property(M => M.Price).HasColumnType("decimal (18 , 2)");
            builder.Property(M => M.Name).IsRequired().HasMaxLength(100);
            builder.HasOne(M => M.Menu)
               .WithMany()
               .HasForeignKey(M => M.MenuId);

        }
    }
}
