using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIP_App.Models
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
