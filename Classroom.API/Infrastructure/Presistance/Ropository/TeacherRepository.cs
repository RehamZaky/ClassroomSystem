using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Infrastructure.Presistance.Repository;

namespace Classroom.API.Infrastructure.Presistance.Ropository
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public TeacherRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<List<User>> GetAllTeachers()
        {
            return await _dbContext.Users.Where(t => t.IsActive && t.UserType == UserType.Teacher).Include(t => t.teacher).ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _dbContext.Users.Include(s => s.teacher).Where(s => s.IsActive && s.Id == id).FirstOrDefaultAsync();

        }
    }
}
