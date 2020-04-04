using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace MSIP_App.Models
{
    public class Events
    {
        [Key]
        public long Id { get; set; }
        public string EventData { get; set; }
        public DateTime EventDate { get; set; }
        public User EventUser { get; set; }
        public Tasks EventTask { get; set; }

        public DateTime SetEventDateTime(DateTime date)
        {
            return EventDate = date;
        }
    }
}
