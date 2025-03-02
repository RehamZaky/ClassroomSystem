using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Infrastructure.Presistance.Repository;

namespace Classroom.API.Infrastructure.Presistance.Ropository
{
    public class ParentRepository : Repository<Parent>, IParentRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public ParentRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;
        }

        public async Task<User?> DeActivateParent(int id)
        {
            var parent = await _dbcontext.Users.Where(s => s.Id == id).Include(s => s.parent).FirstOrDefaultAsync();
            if (parent == null)
            {
                return null;
            }
            //deactivate students
            parent.IsActive = false;
            _dbcontext.Users.Update(parent);
           await _dbcontext.SaveChangesAsync();
            return parent;

        }

        public async Task<List<User>> GetAllParentsWithUser()
        {
            return await _dbcontext.Users.Where(s=> s.IsActive && s.UserType == UserType.Parent).Include(s=> s.parent).ToListAsync();
        }
    }
}
