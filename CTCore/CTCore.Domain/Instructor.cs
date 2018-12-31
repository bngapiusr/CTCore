using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CTCore.Domain
{
    public class Instructor
    {
        public Instructor()
        {
            ScList = new List<StudentClass>();
           // InstructorList = new List<Instructor>();
        }
        public int InstructorId { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        public List<StudentClass>ScList { get; set; }
      //  public List<Instructor> InstructorList { get; set; }
    }
}