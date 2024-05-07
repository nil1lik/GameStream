using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Streaming:BaseEntity<int>
    {
        public int GameId { get; set; }
        public int StreamerId { get; set; }
        public string Title { get; set; }
        public string GameName { get; set; }

        public Game Game { get; set; }
        public Streamer Streamer { get; set; }
    }
}
