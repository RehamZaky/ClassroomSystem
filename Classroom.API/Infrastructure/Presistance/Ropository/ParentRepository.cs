﻿using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Context;
using MovieSystem.Infrastructure.Presistance.Repository;

namespace Classroom.API.Infrastructure.Presistance.Ropository
{
    public class ParentRepository : Repository<Parent>, IParentRepository
    {
        public ParentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
