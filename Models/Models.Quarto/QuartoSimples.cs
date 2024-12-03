using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.Models.Models.room
{
    public class QuartoSimples
    {
        public Quarto quarto { get; set; }
        public QuartoSimples(Quarto room) 
        {
            quarto = room;

        }

    }
}
