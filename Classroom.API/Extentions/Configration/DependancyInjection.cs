using Classroom.API.Application.Repository.Interface;
using Classroom.API.Infrastructure.Presistance.Ropository;
using MovieSystem.Infrastructure.Presistance.Repository;
using Classroom.API.Application.Service.Classroom;
using Classroom.API.Application.Automapper;
namespace Classroom.API.Extentions.Configration
{
    public static class DependancyInjection 
    {
        public static IServiceCollection CustomConfigrationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IClassroomRepository, ClassroomRepository>();
            services.AddTransient<IClassroomService, ClassroomService>();
            
            var assembly = typeof(Program).Assembly;
            services.AddAutoMapper(assembly);

            // custom profile mapper class
            services.AddAutoMapper(typeof(ClassroomProfile).Assembly);
            return services;
        }
    }
}

