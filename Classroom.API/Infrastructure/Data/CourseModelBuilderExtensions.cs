using Classroom.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Classroom.API.Infrastructure.Data
{
    public static class CourseModelBuilderExtensions 
    {
        public static void CourseSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(new Course() { 
                Id = 1,
                CategoryID = 1,
                Category = null,
                CreatedAt = DateTime.UtcNow,
                IsActive = true,
                Title = "New .Net Course",
                Description = "",
            
            });

            modelBuilder.Entity<ClassroomsCourses>().HasData(new ClassroomsCourses() { 
                
                Id=1,
                ClassroomId = 3,
                CourseId = 1,
            });
        }

        public static void QuizSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quiz>().HasData(
                new Quiz()
                {
                    Id = 1,
                    Title = "Identity Quiz",
                    CreatedAt = DateTime.UtcNow,
                    ClassroomId = 3,
                    Description = "Quiz 1",
                    IsOpen = true,
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(5),
                    TotalScore = 100,
                });
        }
    }
}
