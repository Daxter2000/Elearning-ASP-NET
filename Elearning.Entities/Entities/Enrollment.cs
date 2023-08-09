using Elearning.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities.Entities
{
    public class Enrollment : BaseEntity
    {
        public DateTime EnrollmentDate { get; set; }
        public int Status { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set;}
    }
}
