using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORETESTE.Models.Models.Host;
using EFCORETESTE.Models.Models.room;

namespace EFCORETESTE.Models.Models.Reserva
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Hospede hospede { get; set; }
        [Required]
        public Quarto quarto { get; set; }
        [Required]
        public DateTime Datacheckin { get; set; }
        [Required]
        public DateTime Datacheckout { get; set; }
        public Decimal ValorTotal { get; set; }
        
        public Reserva(Hospede host,Quarto room,DateTime checkin,DateTime checkout,decimal total) 
        {
            this.hospede = host;
            this.quarto = room;
            this.Datacheckin = checkin;
            this.Datacheckout = checkout;
            this.ValorTotal = total;


        }
        public Reserva() 
        {

        }


    }
}
