namespace Classroom.API.Infrastructure.Context
{
    using Classroom.API.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using static NPOI.HSSF.Util.HSSFColor;

    public class ClassroomsConfig : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
         
            builder.ToTable("Classrooms");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasMaxLength(1000);

            builder.Property(c => c.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(c => c.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            //builder.HasOne(c => c.Course)
            //    .WithMany(co => co.Classroom)
            //    .HasForeignKey(c => c.CourseId)
            //    .OnDelete(DeleteBehavior.NoAction);


            //builder.HasMany(c => c.Quizzes)
            //    .WithOne(q => q.Classroom)
            //    .HasForeignKey(q => q.ClassroomId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany(c => c.Discussions)
            //    .WithOne(d => d.Classroom)
            //    .HasForeignKey(d => d.ClassroomId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany(c => c.UserClassrooms)
            //    .WithOne(uc => uc.Classroom)
            //    .HasForeignKey(uc => uc.ClassroomId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }

       
    }

}