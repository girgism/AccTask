using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccFlex.Models
{
    public class Course
    {
        public int ID { get; set; }

        [Display(Name = "Course Name ")]
        public string Name { get; set; }

        [Display(Name = " Start Date")]
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }

        [Display(Name="Teacher")]
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
