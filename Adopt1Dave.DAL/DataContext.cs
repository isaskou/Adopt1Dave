using Adopt1Dave.DAL.DataSet;
using Adopt1Dave.DAL.Entities;
using Adopt1Dave.DAL.EntitiesConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dave.DAL
{
    public class DataContext : DbContext
    {
        private readonly string _connString;
        public DataContext()
        {
            _connString = @"server=LAPTOP-03RLPA2O\SQLEXPRESS;Database=Adopt1Dave; Integrated Security=True;";
        }

        public DataContext(string connString)
        {
            _connString = connString;
        }

        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSalary> UserSalaries { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //les configs
            builder.ApplyConfiguration(new SalaryConfig());
            builder.ApplyConfiguration(new SkillCategoryConfig());
            builder.ApplyConfiguration(new SkillConfig());
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new UserSalaryConfig());
            builder.ApplyConfiguration(new UserSkillConfig());

            //DataSet
            builder.ApplyConfiguration(new DSSalary());
            builder.ApplyConfiguration(new DSSkillCategory());
        }
    }
}
