using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSIP_App.Models
{
    public class MSIPContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<GradeTracker> GradeTrackers { get; set; }

        public DbSet<Forum> Forums { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<Classes> Courses { get; set; }

        public DbSet<Assignments> Assignments { get; set; }

        public DbSet<Urls> Urls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MSIP_APP;Trusted_Connection=True;");
        }

        //Used for the connection string in the startup.cs
        public MSIPContext(DbContextOptions<MSIPContext> options)
            : base(options)
        { }

        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
        }
    }
}
