using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccFlex.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name ="Student Name")]
        public string Name { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }


        [Display(Name = "Gender")]
        public int GenderID { get; set; }
        public Gender Gender { get; set; }

        [Display(Name = "Class")]
        public int ClassID { get; set; }
        public Class Class { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
