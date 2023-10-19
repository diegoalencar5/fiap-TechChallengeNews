﻿using Microsoft.EntityFrameworkCore;
using News.Domain.Entities;

namespace News.Domain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<User> User { get; set; }
    }
}