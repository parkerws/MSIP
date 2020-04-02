using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    class GradeTracker
    {
        public long Id { get; set; }
        public User GradeTrackerUser { get; set; }
        public Classes UserClass { get; set; }
        public Assignments UserAssignment { get; set; }
    }
}
