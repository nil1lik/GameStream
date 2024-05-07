using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class UserGame : BaseEntity<int>
    {
        public int GameId { get; set; }
        public int UserId { get; set; }
        public TimeSpan HoursPlayed { get; set; }
        public bool IsDownloaded { get; set; }

        public Game Game { get; set; }
        public User User { get; set; }
    }
}
