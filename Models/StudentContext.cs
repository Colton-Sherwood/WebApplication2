using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            :base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Colton",
                    LastName = "Sherwood",
                    GPA = 4.0
                },
                new Student {
                    Id = 2,
                    FirstName = "Sally",
                    LastName = "Smith",
                    GPA = 3.0
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Billy",
                    LastName = "Bob",
                    GPA = 2.0
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Mickey",
                    LastName = "Mouse",
                    GPA = 1.0
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Bugs",
                    LastName = "Bunny",
                    GPA = 0.0
                }
            );
        }
    }
}
