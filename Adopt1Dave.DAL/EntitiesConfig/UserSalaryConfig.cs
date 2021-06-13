using Adopt1Dave.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dave.DAL.EntitiesConfig
{
    public class UserSalaryConfig : IEntityTypeConfiguration<UserSalary>
    {
        public void Configure(EntityTypeBuilder<UserSalary> builder)
        {
            builder.ToTable(nameof(UserSalary));
            builder.HasKey(us => new { us.UserId, us.SalaryId });

            builder.Property(us => us.Montant)
                .IsRequired();

            builder.HasOne(s => s.Salary)
                .WithMany(us => us.UserSalaries);

            builder.HasOne(u => u.User)
                .WithMany(us => us.UserSalaries);

            builder.HasCheckConstraint("CK_Montant", "Montant>0");
        }
    }
}
