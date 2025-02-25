using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Configuration;
using Classroom.API.Infrastructure.Data;
using MathNet.Numerics.Distributions;
using Microsoft.EntityFrameworkCore;
using NPOI.POIFS.Properties;

namespace Classroom.API.Infrastructure.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ClassroomSeed();
           // modelBuilder.CategorieSeed();
            modelBuilder.ApplyConfiguration(new UsersConvig());
            modelBuilder.ApplyConfiguration(new StudentConvig());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Domain.Entities.Classroom> classrooms{ get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<Permission> Permissions { get; set; }
        //public DbSet<RolePermission> RolePermissions { get; set; }
        //public DbSet<UserPermission> UserPermissions { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Quiz> Quizzes { get; set; }
        //public DbSet<Question> Questions { get; set; }
        //public DbSet<Answer> Answers { get; set; }
        //public DbSet<Discussion> Discussions { get; set; }
        //public DbSet<UserClassroom> UserClassrooms { get; set; }
        //public DbSet<Report> Reports { get; set; }
        //public DbSet<Payment> Payments { get; set; }
        //public DbSet<AnswerExplanation> AnswerExplanations { get; set; }     
        //public DbSet<ClassroomsCourses> ClassroomsCourses { get; set; }
        //public DbSet<QuizUser> QuizUsers { get; set; }     
        //public DbSet<Message> Messages { get; set; }       
        //public DbSet<QuizeCertification> QuizCertifications { get; set; }
        //public DbSet<AttendanceCertification> AttendanceCertifications { get; set; }
        public DbSet<Student> Students { get; set; }      
        public DbSet<Domain.Entities.Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
