using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MSIP_App.Models
{
    public class Classes
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ClassName { get; set; }
        public string Designator { get; set; }
    }
}
