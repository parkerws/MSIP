using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    class Assignments
    {
        public long Id { get; set; }
        public string AssignmentName { get; set; }
        public string Comments { get; set; }
        public Classes AssignmentClass { get; set; }
    }
}
