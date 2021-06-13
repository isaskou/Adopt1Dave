using System.Collections.Generic;

namespace Adopt1Dave.ASP.Models
{
    public class SkillModel
    {
        public int SkillId { get; set; }
        public string Name { get; set; }

        public virtual SkillCategoryModel SkillCategory { get; set; }
        public virtual IEnumerable<UserSkillModel> UserSkills { get; set; }

    }
}