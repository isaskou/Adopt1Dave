namespace Adopt1Dave.DAL.Entities
{
    public class UserSalary
    {
        public int UserId { get; set; }
        public int SalaryId { get; set; }

        public double Montant { get; set; }

        public User User { get; set; }
        public Salary Salary { get; set; }
    }
}