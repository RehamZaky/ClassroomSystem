using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Classroom.API.Extentions.Configration
{
    public class ClassroomConfiguration : IEntityTypeConfiguration<Domain.Entities.Classroom>
    {

        public void Configure(EntityTypeBuilder<Domain.Entities.Classroom> builder)
        {
            

        }
    }
}



