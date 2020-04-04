using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
=======
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MSIP_App.Models;
>>>>>>> Dingo

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
<<<<<<< HEAD
        public DbSet<Calendar> Calendars { get; set; }
=======
        public DbSet<Calendar> Calendar { get; set; }
>>>>>>> Dingo
        public DbSet<Assignments> Assignments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MSIP_APP;Trusted_Connection=True;");
        }

        //Used for the connection string in the startup.cs
        public MSIPContext(DbContextOptions<MSIPContext> options)
            : base(options)
        { }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> Dingo
