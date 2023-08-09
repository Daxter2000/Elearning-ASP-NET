using Elearning.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities.Entities
{
    public  class Lesson : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }


    }
}
