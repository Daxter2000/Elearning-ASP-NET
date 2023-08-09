using Elearning.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities.Entities
{
    public class Assessment : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime IntialDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ScoreObtained { get; set; }
        public int TotalScore { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
