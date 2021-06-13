using System.Collections.Generic;

namespace Adopt1Dave.DAL.Entities
{
    public class SkillCategory
    {
        public int SkillCategoryId { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Skill> Skills { get; set; }

    }
}