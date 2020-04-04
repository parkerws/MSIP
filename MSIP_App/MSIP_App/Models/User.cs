using System;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
>>>>>>> Dingo

namespace MSIP_App.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateJoined { get; set; }
        public string Bio { get; set; }
        public string LinkedInURL { get; set; }
        public string GitHubURL { get; set; }
        public int ForumPriv { get; set; }

    }
}
