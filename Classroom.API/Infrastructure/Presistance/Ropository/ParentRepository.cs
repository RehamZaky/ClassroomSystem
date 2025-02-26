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

        public Parent? DeActivateParent(int id)
        {
            var parent = _dbcontext.Parents.Where(s => s.Id == id).Include(s => s.User).FirstOrDefault();
            if (parent == null)
            {
                return null;
            }
            //deactivate students
            parent.IsActive = false;
            _dbcontext.Parents.Update(parent);
            _dbcontext.SaveChanges();
            return parent;

        }

        public List<Parent> GetAllParentsWithUser()
        {
            return _dbcontext.Parents.Where(u => u.IsActive).Include(s => s.User).ToList();
        }
    }
}
