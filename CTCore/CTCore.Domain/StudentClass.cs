using System;
using System.ComponentModel.DataAnnotations;

namespace CTCore.Domain
{
    public class StudentClass
    {
        public int StudentClassId { get; set; }
        public int InstructorId { get; set; }
        public int ClassTypeId { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string Rank { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        public DateTime TkdBod { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastTestDate { get; set; }
    }
}