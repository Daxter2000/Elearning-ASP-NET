using Elearning.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities.Entities
{
    public  class Resource : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public ResourceType Type { get; set; }
    }

    public enum ResourceType
    {
        File,
        ExternalUrl
    }
}
