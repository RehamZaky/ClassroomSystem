using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Context;
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

        public List<Student> GetAllStudentsWithUsers()
        {
            return _dbContext.Students.Where(u => u.IsActive).Include(s=> s.User).ToList();
        }

        public Student? DeActivateStudent(int id)
        {
           var student = _dbContext.Students.Where(s => s.Id == id).Include(s=>s.User).FirstOrDefault();
            if(student == null)
            {
                return null;
            }
            student.IsActive = false;
            _dbContext.Students.Update(student);
            _dbContext.SaveChanges();
            return student;
        }
    }
}
