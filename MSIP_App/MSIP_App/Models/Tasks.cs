using System;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> Dingo
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSIP_App.Models
{
    public class Tasks
    {
        [Key]
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
<<<<<<< HEAD
=======
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MSIP_App
{
    public class Tasks
    {
        public long Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Title must contain at least two characters.")]
        [MaxLength(200, ErrorMessage = "Title must contain a maximum of 200 characters.")]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        
        public User TaskOwner { get; set; }

        [DisplayName("Complete")]
        public bool IsComplete { get; set; }


    }
}
>>>>>>> WillBranch
=======
>>>>>>> Dingo
