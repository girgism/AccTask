using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccFlex.Models
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student Student { get; set; }
    }
}
