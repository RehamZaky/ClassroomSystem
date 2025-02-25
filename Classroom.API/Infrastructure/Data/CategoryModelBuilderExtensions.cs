using Classroom.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Classroom.API.Infrastructure.Data
{
    public static class CategoryModelBuilderExtensions
    {
        public static void CategorieSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Domain.Entities.Category
                {
                    Id = 1,
                    Name = "Programming",
                    ParentId = 0,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Category
                {
                    Id = 2,
                    Name = "Web Development",
                    ParentId = 1, 
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Category
                {
                    Id = 3,
                    Name = "Databases",
                    ParentId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Category
                {
                    Id = 4,
                    Name = "ASP.NET",
                    ParentId = 2, 
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Category
                {
                    Id = 5,
                    Name = "SQL",
                    ParentId = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }
    }
}
