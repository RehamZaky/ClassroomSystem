using Classroom.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Classroom.API.Infrastructure.Configuration
{
    public class UsersConvig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserType).IsRequired();


            builder.HasMany(x=> x.QuizAttempts)
                .WithOne(s=> s.User)
                .HasForeignKey(x=> x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
