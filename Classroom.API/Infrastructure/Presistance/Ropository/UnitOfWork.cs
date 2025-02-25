using Classroom.API.Application.Repository.Interface;
using Classroom.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Infrastructure.Presistance.Repository;
using NPOI.SS.Formula.Functions;

namespace Classroom.API.Infrastructure.Presistance.Ropository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly Dictionary<Type,object> _repostotyes = new Dictionary<Type,object>();
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> CompleteAsync()
        {
           return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repostotyes.ContainsKey(typeof(T)))
                return _repostotyes[typeof(T)] as IRepository<T>;

            var repository = new Repository<T>(_context);
            _repostotyes[typeof(T)]= repository;
            return repository;
        }
    }
}
