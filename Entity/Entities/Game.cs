using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Game : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<UserGame> UserGames { get; set; }
        public ICollection<Streaming> Streamings { get; set; }
        public ICollection<GameImage> GameImages { get; set; }

    }
}
