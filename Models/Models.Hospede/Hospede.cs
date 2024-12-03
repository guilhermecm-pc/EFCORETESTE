using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.Models.Models.Host
{
    public class Hospede
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public DateTime Datanascimento { get; set; }


        public Hospede(string nome, string cpf, DateTime nascimento, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Datanascimento = nascimento;
            Endereco = endereco;
        }
        public Hospede()
        {
        }

    }
}
