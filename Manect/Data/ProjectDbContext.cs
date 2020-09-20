﻿using Microsoft.EntityFrameworkCore;
using Manect.Data.Entities;
using Manect.DataBaseLogger;

namespace Manect.Data
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Stage> Stages { get; set; }
        public DbSet<Project> FurnitureProjects { get; set; }
        public DbSet<ExecutorUser> ExecutorUsers { get; set; }
        public DbSet<HistoryItem> LogUserActivity { get; set; }
    }
}
