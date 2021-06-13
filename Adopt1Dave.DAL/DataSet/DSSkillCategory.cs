using Adopt1Dave.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dave.DAL.DataSet
{
    public class DSSkillCategory : IEntityTypeConfiguration<SkillCategory>
    {
        public void Configure(EntityTypeBuilder<SkillCategory> builder)
        {
            builder.HasData(
                new SkillCategory { SkillCategoryId = 1, Name = "Back-end" },
                new SkillCategory { SkillCategoryId = 2, Name = "Front-End" },
                new SkillCategory { SkillCategoryId = 3, Name = "Bureautique" },
                new SkillCategory { SkillCategoryId = 4, Name = "Système" },
                new SkillCategory { SkillCategoryId = 5, Name = "Outils" }
                );
        }
    }
}
