using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSIP_App.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Location { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string PhoneNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public DateTime DateJoined { get; set; }
        public string Bio { get; set; }
        public string LinkedInURL { get; set; }
        public string GitHubURL { get; set; }
        public int ForumPriv { get; set; }

    }
}
