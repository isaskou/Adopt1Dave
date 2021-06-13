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
    public class UserSkillConfig : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            builder.ToTable(nameof(UserSkill));

            builder.HasKey(us => new { us.UserId, us.SkillId });

            builder.Property(us => us.score)
                .IsRequired();

            builder.HasOne(s => s.User)
                .WithMany(u => u.UserSkills);

            builder.HasOne(s => s.Skill)
                .WithMany(u => u.UserSkills);

            builder.HasCheckConstraint("CK_Score", "Score BETWEEN 0 AND 10");
        }
    }
}
