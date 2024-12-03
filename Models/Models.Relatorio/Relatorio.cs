using EFCORETESTE.Models.Models.Host;
    using EFCORETESTE.Models.Models.Reserva;
    using EFCORETESTE.Models.Models.room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelfinalproject.Models.Models.Report
{
    public class RelatorioOcupacao
    {
        public int id { get; set; }
        DateTime DataGeracao { get; set; }
        ICollection<Reserva> ReservasAtivas { get; set; }
    }
    public class RelatorioFaturamento 
    {
        public int id { get; set; }
        public DateTime DataGeracao { get;set; }
        public decimal TotalFaturamento { get; set; } 

    }
}

