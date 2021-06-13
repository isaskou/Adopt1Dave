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
    public class SalaryConfig : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.ToTable(nameof(Salary));

            builder.HasKey(s => s.SalaryId);

            builder.Property(s => s.Period)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasIndex(s => s.Period)
                .IsUnique();


        }
    }
}
