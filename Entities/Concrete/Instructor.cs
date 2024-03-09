using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Instructor :BaseEntity
    {
        public string LastName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
