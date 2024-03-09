using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course : BaseEntity
    {
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public decimal Price { get; set; }
    }
}
