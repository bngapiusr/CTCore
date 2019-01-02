using System;
using System.Collections.Generic;
using System.Text;
using CTCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
namespace CTCore.Data
{
    public class CtCoreDbContext : DbContext
    {
        //Logger factory logs messages to the console app

        public static readonly LoggerFactory CtCoreConsoleLoggerFactory = new LoggerFactory(new[]
        {
            new ConsoleLoggerProvider((category, level)
                => category==DbLoggerCategory.Database.Command.Name
                   && level == LogLevel.Information, true)
        });


        public DbSet<StudentClass> StudentClass { get; set; }
        public DbSet<ClassType> ClassType { get; set; }
        public DbSet<Instructor> Instructor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(CtCoreConsoleLoggerFactory)
                .UseSqlServer(@"Data Source=.;Database=CTCore;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
