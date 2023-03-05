using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccFlex.Models
{
    public class StudentCourse
    {
        [Key]
        [Display(Name = "Courses")]
        public int CourseID { get; set; }
        
        [Key]
        [Display(Name = "Students")]
        public int StudentID { get; set; }

        [ForeignKey("CourseID")]
        public Course Course { get; set; }

        [ForeignKey("StudentID")]
        public Student Student { get; set; }
    }
}
