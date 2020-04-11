using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSIP_App.Models
{
    public class Calendar
    {
        [Key]
        public long Id { get; set; }
        public List<Events> Events { get; set; }
        public List<Tasks> Tasks { get; set; }
    }
}
