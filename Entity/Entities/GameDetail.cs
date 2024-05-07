using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class GameDetail:BaseEntity<int>
    {
        public int GameId { get; set; }
        public string GameType { get; set; }
        public string Platform { get; set; }
        public double? Rate { get; set; }
        public long? DownloadQuantity { get; set; }
        public string DiskSize { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; }

        public Game Game { get; set; }
    }
}
