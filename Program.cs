using System;
using EFCORETESTE.Models.Models.Host;
using EFCORETESTE.Models.Models.Reserva;
using EFCORETESTE.Models.Models.room;
using EFCORETESTE.Repository;
using EFCORETESTE.UI;
using Hotelfinalproject.Repository;

namespace EFCORETESTE
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioHospede main = new();
            RepositorioQuarto main2 = new();
            RepositorioReserva main3 = new();
            using (var Dados = new Hotel_Dbcontext())
            {
                DateTime data1 = (DateTime.Parse("11/25/2024"));
                DateTime data2 = (DateTime.Parse("11/30/2024"));
                Hospede hospede = new("Pafuncio", "1234567891123", DateTime.Now, "USA BRO");
                Hospede hospede2 = new("Praxedes","44535345435543",DateTime.Now, "aqui e brasil");
                //main.AdicionaHospede(hospede);
                //main.AdicionaHospede(hospede2);
                //main.AtualizaHospede(20);
                //main.RemoveHospede(3);
                //main.ExibeHospede();






                Quarto quarto = new Quarto(1, 200);
                Quarto quarto2 = new Quarto(102, 250);
                //main2.AdicionaQuarto(quarto);
                //main2.AdicionaQuarto(quarto2);

                Reserva reserva = new Reserva(hospede,quarto,data1,data2,1000);
                Reserva reserva2 = new Reserva(hospede2, quarto2, data1, data2, 1000);
                //main3.ExibeReserva();

                
                
            }
        }
    }
}
