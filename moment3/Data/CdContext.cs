using System;
using Microsoft.EntityFrameworkCore;
using moment3.Models;

namespace moment3.Data
{
    public class CdContext : DbContext
    {
        public CdContext(DbContextOptions<CdContext> options) : base(options)
        {
        }
        public DbSet<Cd> Cd { get; set; }
        public DbSet<Genres> Genres { get; set; }

    }
}


