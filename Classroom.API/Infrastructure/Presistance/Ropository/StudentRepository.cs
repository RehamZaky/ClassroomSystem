using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Context;
using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Infrastructure.Presistance.Repository;

namespace Classroom.API.Infrastructure.Presistance.Ropository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<List<User>> GetallUserStudent()
        {
            return await _dbContext.Users.Include(s => s.Students).Where(s => s.IsActive && s.UserType == UserType.Student).ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _dbContext.Users.Include(s => s.Students).Where(s => s.IsActive && s.Id == id).FirstOrDefaultAsync();
        }

        public async Task<User?> DeActivateStudent(int id)
        {
            var userStudent = await _dbContext.Users.Where(s=> s.Id.Equals(id)).Include(s=> s.Students).FirstOrDefaultAsync();
            await _dbContext.Students.Where(s => s.Id == id).Include(s=>s.User).FirstOrDefaultAsync();
            if(userStudent == null)
            {
                return null;
            }
            userStudent.IsActive = false;
            _dbContext.Users.Update(userStudent);
            _dbContext.SaveChanges();
            return userStudent;
        }

        public async Task<User> EnrollStudentToCourse(int userId, int courseId)
        {
          var user =  await _dbContext.Users.Where(s => s.Id == userId).Include(s=> s.Students).Include(c=>c.Course).FirstOrDefaultAsync();
            if(user == null)
            {
                return null;
            }

            user.CourseId = courseId;
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }
    }
}
