

using NPOI.SS.Formula.Functions;

namespace Classroom.API.Application.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;
        Task<int> CompleteAsync();
    }
}
