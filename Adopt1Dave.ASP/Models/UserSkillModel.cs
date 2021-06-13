using Adopt1Dave.DAL.Entities;

namespace Adopt1Dave.ASP.Models
{
    public class UserSkillModel
    {
        public int UserId { get; set; }
        public int SkillId { get; set; }
        public int score { get; set; }

        public virtual User User { get; set; }
        public virtual Skill Skill { get; set; }

    }
}