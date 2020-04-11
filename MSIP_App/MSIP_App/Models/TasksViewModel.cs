using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIP_App.Models
{
    public class TasksViewModel
    {
        public Tasks Tasks { get; set; }
        public IEnumerable<Tasks> TaskList { get; set; }
    }
}
