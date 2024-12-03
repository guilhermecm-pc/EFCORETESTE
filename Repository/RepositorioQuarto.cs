using EFCORETESTE.Models.Models.room;
using EFCORETESTE.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.Repository
{
    public class RepositorioQuarto
    {
        private Hotel_Dbcontext dados = new();

        public void AdicionaQuarto(Quarto novo) 
        {
            dados.Add(novo);
            Console.WriteLine("Quarto Adicionado!");
            dados.SaveChanges();
        }
        public void AtualizaQuarto(int id) 
        {
            var QuartoAtual = dados.quartos.Find(id);
            if (QuartoAtual == null) return;
            Quarto aux = Cadastro.CadastroQuarto();
            QuartoAtual.Numero = aux.Numero;
            QuartoAtual.Valorpordia = aux.Valorpordia;
            QuartoAtual.Ocupacao = aux.Ocupacao;
            Console.WriteLine("Quarto Atualizado!");
            dados.SaveChanges();
        }
        public void RemoveQuarto(int id) 
        {
            var QuartoAtual = dados.quartos.Find(id);
            if (QuartoAtual == null) return;
            dados.Remove(QuartoAtual);
            Console.WriteLine("Quarto Removido!");
            dados.SaveChanges();
        }
        public void ExibeQuartos() 
        {
            foreach (var Quarto in dados.quartos)
                Console.WriteLine($"Id do quarto:{Quarto.Id},Numero do quarto: {Quarto.Numero},Valor por dia:{Quarto.Valorpordia}");
        }
        public Quarto ObterQuarto(int id) 
        {
            var QuartoAtual = dados.quartos.Find(id);
            return QuartoAtual;
        }
        public void OcupaQuarto(int id) 
        {
            
            var QuartoAtual = dados.quartos.Find(id);
            QuartoAtual.Ocupacao = true;
            dados.SaveChanges();
            return;
        }
        public void TipoQuarto(int id,string tipo) 
        {
           

        }
        public decimal CalculaValorTotal(DateTime checkin,DateTime checkout, decimal valor) 
        {
            decimal valorTotal = 0;
            while(checkin < checkout) 
            {
                valorTotal += valor;
                checkin = checkin.AddDays(1);
            }
            return valorTotal;

        }

    }
}
