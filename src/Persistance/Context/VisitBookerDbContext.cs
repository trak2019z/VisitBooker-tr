﻿using Microsoft.EntityFrameworkCore;

namespace Persistance.Context
{
    public class VisitBookerDbContext : DbContext
    {
        public VisitBookerDbContext(DbContextOptions<VisitBookerDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies();
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VisitBookerDbContext).Assembly);
        }
    }
}