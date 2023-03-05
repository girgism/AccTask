using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccFlex.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
