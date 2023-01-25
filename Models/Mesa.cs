using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgRPG.Models
{
    public class Mesa
    {
        public int MesaId { get; set; }
        public Sistema? Sistema { get; set; }
        public ICollection<Player>? Players { get; set; }
        public Mestre? Mestre { get; set; }
    }
}