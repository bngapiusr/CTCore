using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CTCore.Domain
{
    public class ClassType
    {
        public ClassType()
        {
          //  ClassTypeList = new List<ClassType>();
            StudentClassesList = new List<StudentClass>();

        }
        public int ClassTypeId { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Description { get; set; }

      //  public List<ClassType> ClassTypeList { get; set; }
        public List<StudentClass> StudentClassesList { get; set; }

    }
}