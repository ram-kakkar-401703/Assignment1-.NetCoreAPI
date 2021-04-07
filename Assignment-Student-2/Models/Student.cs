using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Student_2.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]

        public int RollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
