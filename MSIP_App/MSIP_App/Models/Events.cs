using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    class Events
    {
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
