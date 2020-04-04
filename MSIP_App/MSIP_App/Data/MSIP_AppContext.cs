using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSIP_App.Models
{
    public class MSIP_AppContext : DbContext
    {
        public MSIP_AppContext (DbContextOptions<MSIP_AppContext> options)
            : base(options)
        {
        }

        public DbSet<MSIP_App.Models.User> User { get; set; }
    }
}
