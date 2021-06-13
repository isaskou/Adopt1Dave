using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dave.DAL.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }

        public virtual SkillCategory SkillCategory { get; set; }
        public virtual IEnumerable<UserSkill> UserSkills { get; set; }

    }
}
