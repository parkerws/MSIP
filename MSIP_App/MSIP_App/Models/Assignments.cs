using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace MSIP_App.Models
{
    public class Assignments
    {
        [Key]
        public long Id { get; set; }
        public string AssignmentName { get; set; }
        public string Comments { get; set; }
        public Classes AssignmentClass { get; set; }
    }
}
