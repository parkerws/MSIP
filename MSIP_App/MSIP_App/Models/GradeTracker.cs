using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSIP_App.Models
{
    public class GradeTracker
    {
        [Key]
        public long Id { get; set; }
        public User GradeTrackerUser { get; set; }
        public Classes UserClass { get; set; }
        public Assignments UserAssignment { get; set; }
    }
}
