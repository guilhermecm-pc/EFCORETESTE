using EFCORETESTE.Models.Models.Reserva;
using EFCORETESTE.Repository;
using EFCORETESTE.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelfinalproject.Repository
{
    public class RepositorioReserva
    {
        Hotel_Dbcontext dados = new();
        public void AdicionarReserva(Reserva reserva) 
        {
            dados.Add(reserva);
            dados.SaveChanges();
        }
        public void AtualizaReserva(int id) 
        {
            var ReservaAtual = dados.reservade.Find(id);
            if (ReservaAtual == null) return;
            Reserva aux = Cadastro.CadastroReserva();
            if (aux == null) return;
            ReservaAtual.hospede = aux.hospede;
            ReservaAtual.quarto = aux.quarto;
            ReservaAtual.Datacheckin = aux.Datacheckin;
            ReservaAtual.Datacheckout = aux.Datacheckout;
            ReservaAtual.ValorTotal = aux.ValorTotal;
            dados.SaveChanges();
        }
        public void RemoveReserva(int id) 
        {
            var ReservaAtual = dados.reservade.Find(id);
            if (ReservaAtual == null) 
            {
                Console.WriteLine("Reserva nao encontrada!");
                return;
            }
            else 
            {
                dados.Remove(ReservaAtual);
                Console.WriteLine("Reserva excluida com sucesso!");
                dados.SaveChanges();

            }
            

        }
        public void CarregarReservas()
        {
            var reserva = dados.reservade  
                .Include(r => r.hospede)
                .Include(r => r.quarto)
                .ToList();
        }
        public void ExibeReserva() 
        {
            CarregarReservas();
            foreach (var reserva in dados.reservade)
            {
                Console.WriteLine($"Reserva id: {reserva.Id}, Nome Hospede {reserva.hospede.Nome}, Numero do quarto {reserva.quarto.Numero},Data checkin {reserva.Datacheckin},Data checkout {reserva.Datacheckout},Valor total Reserva {reserva.ValorTotal}");
            }
        }
       
    }
}
