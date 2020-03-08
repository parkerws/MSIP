using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    class Tasks
    {
        public long Id { get; set; }
        public string TaskText { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public User TaskOwner { get; set; }

        public DateTime StartDateSetter(DateTime date)
        {
            return StartDate = date;
        }

        public DateTime DueDateSetter(DateTime date)
        {
            return DueDate = date;
        }
    }
}
