using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorTemplatesLawler.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Lukas", LastName = "Lawler", Grade = "A-" },
                new Student { StudentId = 2, FirstName = "David", LastName = "Davison", Grade = "C" },
                new Student { StudentId = 3, FirstName = "Al", LastName = "Bundy", Grade = "D+" },
                new Student { StudentId = 4, FirstName = "Ed", LastName = "Eddneddy", Grade = "F" }
            );
        }
    }
}
