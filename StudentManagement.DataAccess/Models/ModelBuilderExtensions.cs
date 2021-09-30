using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.DataAccess.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Muhammadqodir",
                    LastName = "To'ychiboyev",
                    MiddleName = "Jumaboy o'g'li",
                    PassportNumber = "AB 0000000",
                    Login = "admin",
                    Parol = "111",
                    Department = "admin"
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Jo'rabek",
                    LastName = "To'xtasinov",
                    MiddleName = "Otabek o'g'li",
                    PassportNumber = "AB 0000000",
                    Login = "user",
                    Parol = "222",
                    Department = "user"
                }
                );
        }
    }
}
