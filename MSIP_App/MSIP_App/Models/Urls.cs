using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSIP_App.Models
{
    public class Urls
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string  Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Url { get; set; }

    }
}
