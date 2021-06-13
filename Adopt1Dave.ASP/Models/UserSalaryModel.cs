using Adopt1Dave.DAL.Entities;

namespace Adopt1Dave.ASP.Models
{
    public class UserSalaryModel
    {
        public int UserId { get; set; }
        public int SalaryId { get; set; }

        public double Montant { get; set; }

        public User User { get; set; }
        public Salary Salary { get; set; }


    }
}