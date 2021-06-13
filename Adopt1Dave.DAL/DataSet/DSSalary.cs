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
    public class DSSalary : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.HasData(
                new Salary { SalaryId = 1, Period = "Hour" },
                new Salary { SalaryId = 2, Period = "Day" },
                new Salary { SalaryId = 3, Period = "Month" }
                );
        }
    }
}
