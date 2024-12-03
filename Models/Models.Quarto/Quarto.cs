using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.Models.Models.room
{
    public class Quarto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public bool Ocupacao { get; set; }
        [Required]
        public decimal Valorpordia { get; set; }

        public Quarto(int numero,decimal valor)
        {
            Numero = numero;
            Valorpordia = valor;
            Ocupacao = false;
        }
        public Quarto() 
        {

        }

    }
}
