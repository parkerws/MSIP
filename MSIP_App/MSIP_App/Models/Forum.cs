using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MSIP_App.Models
{
    public class Forum
    {
        [Key]
        public long MessageId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string TopicName { get; set; }

        [Required]
        public int Importance { get; set; }

        [Required]
        public string MessageBody { get; set; }
        public DateTime TimeStamp
        {
            get { return this.TimeStamp; }
            set { TimeStamp = DateTime.Now; }
        }
        public User ForumUser { get; set; }


    }
}
