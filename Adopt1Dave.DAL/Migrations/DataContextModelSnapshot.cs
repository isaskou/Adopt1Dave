﻿// <auto-generated />
using System;
using Adopt1Dave.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adopt1Dave.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.Salary", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SalaryId");

                    b.HasIndex("Period")
                        .IsUnique();

                    b.ToTable("Salary");

                    b.HasData(
                        new
                        {
                            SalaryId = 1,
                            Period = "Hour"
                        },
                        new
                        {
                            SalaryId = 2,
                            Period = "Day"
                        },
                        new
                        {
                            SalaryId = 3,
                            Period = "Month"
                        });
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("SkillCategoryId")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("SkillCategoryId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.SkillCategory", b =>
                {
                    b.Property<int>("SkillCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SkillCategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("SkillCategory");

                    b.HasData(
                        new
                        {
                            SkillCategoryId = 1,
                            Name = "Back-end"
                        },
                        new
                        {
                            SkillCategoryId = 2,
                            Name = "Front-End"
                        },
                        new
                        {
                            SkillCategoryId = 3,
                            Name = "Bureautique"
                        },
                        new
                        {
                            SkillCategoryId = 4,
                            Name = "Système"
                        },
                        new
                        {
                            SkillCategoryId = 5,
                            Name = "Outils"
                        });
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("ImageFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageMimeType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasCheckConstraint("CK_Email", "Email LIKE '_%@_%'");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.UserSalary", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<double>("Montant")
                        .HasColumnType("float");

                    b.HasKey("UserId", "SalaryId");

                    b.HasIndex("SalaryId");

                    b.ToTable("UserSalary");

                    b.HasCheckConstraint("CK_Montant", "Montant>0");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.UserSkill", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("UserId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("UserSkill");

                    b.HasCheckConstraint("CK_Score", "Score BETWEEN 0 AND 10");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.Skill", b =>
                {
                    b.HasOne("Adopt1Dave.DAL.Entities.SkillCategory", "SkillCategory")
                        .WithMany("Skills")
                        .HasForeignKey("SkillCategoryId");

                    b.Navigation("SkillCategory");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.UserSalary", b =>
                {
                    b.HasOne("Adopt1Dave.DAL.Entities.Salary", "Salary")
                        .WithMany("UserSalaries")
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Adopt1Dave.DAL.Entities.User", "User")
                        .WithMany("UserSalaries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salary");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.UserSkill", b =>
                {
                    b.HasOne("Adopt1Dave.DAL.Entities.Skill", "Skill")
                        .WithMany("UserSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Adopt1Dave.DAL.Entities.User", "User")
                        .WithMany("UserSkills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.Salary", b =>
                {
                    b.Navigation("UserSalaries");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.Skill", b =>
                {
                    b.Navigation("UserSkills");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.SkillCategory", b =>
                {
                    b.Navigation("Skills");
                });

            modelBuilder.Entity("Adopt1Dave.DAL.Entities.User", b =>
                {
                    b.Navigation("UserSalaries");

                    b.Navigation("UserSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
