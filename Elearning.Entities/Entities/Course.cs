using Elearning.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; } 
        public DateOnly InitialDate { get; set; }
        public int Duration { get; set; }
        public int Level { get; set; }
        public Category Category { get; set; }
        public string Requirements { get; set; }
    }
}
