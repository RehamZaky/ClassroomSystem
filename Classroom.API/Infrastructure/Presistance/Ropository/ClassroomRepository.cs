using Classroom.API.Application.Repository.Interface;
using Classroom.API.Infrastructure.Context;
using MovieSystem.Infrastructure.Presistance.Repository;

namespace Classroom.API.Infrastructure.Presistance.Ropository
{
    public class ClassroomRepository : Repository<Domain.Entities.Classroom> , IClassroomRepository
    {
        public ClassroomRepository(ApplicationDbContext contxt) : base(contxt) { }
        
    }
}
