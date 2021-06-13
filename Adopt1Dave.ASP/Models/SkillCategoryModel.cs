using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopt1Dave.ASP.Models
{
    public class SkillCategoryModel
    {
        public int SkillCategoryId { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<SkillModel> Skills { get; set; }
    }
}
