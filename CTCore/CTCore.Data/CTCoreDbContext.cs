using System;
using System.Collections.Generic;
using System.Text;
using CTCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CTCore.Data
{
    public class CtCoreDbContext : DbContext
    {
        public DbSet<StudentClass> StudentClass { get; set; }
        public DbSet<ClassType> ClassType { get; set; }
        public DbSet<Instructor> Instructor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Database=CTCore;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
