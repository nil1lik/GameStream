using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class GameImage : BaseEntity<Guid>
    {
        public Guid GameId { get; set; }
        public string ImageUrl { get; set; }

        public Game Game { get; set; }
    }
}
