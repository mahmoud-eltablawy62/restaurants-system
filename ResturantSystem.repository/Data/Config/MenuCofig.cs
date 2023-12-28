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
    internal class MenuCofig : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasOne(m => m.Res)
            .WithOne(r => r.Menus)
            .HasForeignKey<Menu>(m => m.ResId);
        }
    }
}
