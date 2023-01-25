using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProgRPG.Models
{
    public class MesasPlayers
    {
        public int MesasJogadoresId { get; set; }
        [ForeignKey("Mesa")]
        public Mesa Mesa { get; set; }
        public int FkMesa { get; set; }
        [ForeignKey("Player")]
        public Player Player { get; set; }
        public int FkPlayer { get; set; }

    }
}