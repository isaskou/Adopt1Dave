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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.HasKey(u => u.UserId);

            builder.Property(u => u.Email)
                .HasMaxLength(255)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(u => u.FirstName)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(u => u.LastName)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(u => u.Password)
                .IsRequired();

            builder.Property(u => u.ImageMimeType)
                .HasMaxLength(50);

            builder.HasCheckConstraint("CK_Email", "Email LIKE '_%@_%'")
                .HasIndex(u => u.Email)
                .IsUnique();

        }
    }
}
