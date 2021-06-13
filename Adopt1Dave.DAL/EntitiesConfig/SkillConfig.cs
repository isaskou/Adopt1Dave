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
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable(nameof(Skill));

            builder.HasKey(s => s.SkillId);

            builder.Property(s => s.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasOne(s => s.SkillCategory)
                .WithMany(sc => sc.Skills);

            builder.HasIndex(s => s.Name)
                .IsUnique();
        }
    }
}
