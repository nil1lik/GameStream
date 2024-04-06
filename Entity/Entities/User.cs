using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class User : BaseEntity<Guid>
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public ICollection<UserGame> UserGames { get; set; }
    }
}
