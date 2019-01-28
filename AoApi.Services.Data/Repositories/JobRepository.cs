﻿using AoApi.Data;
using AoApi.Data.Models;
using AoApi.Data.Repositories;

namespace AoApi.Services.Data.Repositories
{
    public class JobRepository : RepositoryBase<Job>, IJobRepository
    {
        public JobRepository(AOContext context) : base(context)
        {
        }
    }
}
