using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    class Calendar
    {
        public long Id { get; set; }
        public List<Events> Events { get; set; }
        public List<Tasks> Tasks { get; set; }
    }
}
