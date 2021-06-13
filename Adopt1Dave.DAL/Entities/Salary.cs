using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dave.DAL.Entities
{
    public class Salary
    {
        public int SalaryId { get; set; }

        public string Period { get; set; }

        public IEnumerable<UserSalary> UserSalaries { get; set; }
 
    }
}
