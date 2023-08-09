using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities.Entities
{
    public class Comment
    {
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public ObjectTypeCommented ObjectType { get; set; }
        public int ObjectId { get; set; }
        public Student Student { get; set; }


    }

    public enum ObjectTypeCommented
    {
        Course,
        Lesson,
        Assesment
    }
}
