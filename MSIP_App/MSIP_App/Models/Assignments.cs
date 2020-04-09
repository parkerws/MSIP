using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MSIP_App.Models
{
    public class Assignments
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string AssignmentName { get; set; }
        public string Comments { get; set; }
        public Classes AssignmentClass { get; set; }
    }
}
