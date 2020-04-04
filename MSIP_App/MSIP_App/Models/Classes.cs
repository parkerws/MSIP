using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSIP_App.Models
{
    public class Classes
    {
        [Key]
        public long Id { get; set; }
        public string ClassName { get; set; }
        public string Designator { get; set; }
    }
}
