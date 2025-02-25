using Classroom.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Classroom.API.Infrastructure.Configuration
{

    public class StudentConvig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.ToTable("Students");
            builder.HasOne(u => u.User)
                .WithOne(s => s.Students)
                .HasForeignKey<Student>(u => u.userId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
