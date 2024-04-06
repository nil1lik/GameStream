using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Streamer : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
