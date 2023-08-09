using Elearning.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmailAddressAttribute Email { get; set; }
        public string Password { get; set; }
        public List<Course> CursosInscritos { get; set; }
        public List<Assessment> EvaluacionesCompletadas { get; set; }
    }
}
