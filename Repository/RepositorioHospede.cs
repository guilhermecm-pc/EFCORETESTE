using EFCORETESTE.UI;
using EFCORETESTE.Models.Models.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.Repository
{
    public class RepositorioHospede
    {
        private Hotel_Dbcontext dados = new();

        public void AdicionaHospede(Hospede hospede) 
        {
            dados.Add(hospede);
            Console.WriteLine("Hospede Adicionado!");
            dados.SaveChanges();

        }

        public void AtualizaHospede(int id) 
        {
            var HospedeAtual = dados.hospedes.Find(id);
            if (HospedeAtual == null) return;
            Hospede aux = Cadastro.CadastroHospede();
            HospedeAtual.Nome = aux.Nome;
            HospedeAtual.Cpf = aux.Cpf;
            HospedeAtual.Datanascimento = aux.Datanascimento;
            HospedeAtual.Endereco = aux.Endereco;
            dados.SaveChanges();
           
        }
        public void RemoveHospede(int id) 
        {
            var HospedeSelecionado = dados.hospedes.Find(id);
            if(HospedeSelecionado != null) 
            {
                dados.Remove(HospedeSelecionado);
                Console.WriteLine("Hospede removido!");
                dados.SaveChanges();
            }
            else
            {
                Console.WriteLine("Hospede nao encontrado!");
            }

        }
        public void ExibeHospede() 
        {
            foreach(var Hospede in dados.hospedes) 
            {
                Console.WriteLine($"ID: {Hospede.Id} Nome:{Hospede.Nome} Cpf:{Hospede.Cpf} Nascimento: {Hospede.Datanascimento} Endereço: {Hospede.Endereco}");
            }

        } 
        public Hospede ObterHospede(int id) 
        {
            var HospedeAtual = dados.hospedes.Find(id);
            return (HospedeAtual);
            
        }

    }
}
