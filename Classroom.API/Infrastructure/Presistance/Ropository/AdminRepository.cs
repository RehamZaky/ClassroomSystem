using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Infrastructure.Presistance.Repository;

namespace Classroom.API.Infrastructure.Presistance.Ropository
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AdminRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<User?> GetUserById(int id)
        {
          return  await _dbContext.Users.Where(s => s.Id == id && s.IsActive).Include(s => s.admin).FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetAllAdmins()
        {
            return await _dbContext.Users.Where(s =>  s.IsActive && s.UserType == UserType.Admin).Include(s => s.admin).ToListAsync();

        }

        public async Task<User?> DeActivateAdmin(int id)
        {
            var userAdmin = await _dbContext.Users.Where(s => s.Id.Equals(id)).Include(s => s.admin).FirstOrDefaultAsync();
            if (userAdmin == null)
            {
                return null;
            }
            userAdmin.IsActive = false;
            _dbContext.Users.Update(userAdmin);
            _dbContext.SaveChanges();
            return userAdmin;
        }

    }
}
