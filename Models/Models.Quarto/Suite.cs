using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.Models.Models.room
{
    public class Suite
    {
        public Quarto quarto { get; set; }
        public int Capacidadepessoas { get; set; }

        public Suite(Quarto room, int capacidade)
        {
            this.quarto = room;
            this.Capacidadepessoas = capacidade;

        }


    }
}
