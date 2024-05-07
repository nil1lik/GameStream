using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Streamer : BaseEntity<int>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Streaming> Streamings { get; set; }
    }
}
