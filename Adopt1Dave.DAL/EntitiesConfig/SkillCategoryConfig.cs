using Adopt1Dave.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dave.DAL.EntitiesConfig
{
    class SkillCategoryConfig : IEntityTypeConfiguration<SkillCategory>
    {
        public void Configure(EntityTypeBuilder<SkillCategory> builder)
        {
            builder.ToTable(nameof(SkillCategory));

            builder.HasKey(sc => sc.SkillCategoryId);

            builder.Property(sc => sc.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasIndex(sc => sc.Name)
                .IsUnique();
        }
    }
}
