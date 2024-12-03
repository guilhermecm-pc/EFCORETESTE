using EFCORETESTE.Models.Models.Host;
using EFCORETESTE.Models.Models.Reserva;
using EFCORETESTE.Models.Models.room;
using EFCORETESTE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.UI
{
    public  class Cadastro
    {
        public static Hospede CadastroHospede() 
        {
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();

            System.Console.Write("CPF (formato xxx.xxx.xxx-xx): ");
            string cpf = Console.ReadLine();

            System.Console.Write("Data de nascimento (formato DD/MM/YYYY): ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Endereco de residencia: ");
            string endereco = Console.ReadLine();

            return new Hospede(nome, cpf, nascimento, endereco);
        }
        public static Quarto CadastroQuarto() 
        {
            System.Console.Write("Numero: ");
            string Numero = Console.ReadLine();

            System.Console.Write("Tipo (1 Simples,2 Luxo, 3 Suite) :");
            string Tipo = Console.ReadLine();

            System.Console.Write("Valor por dia: ");
            string Valor = Console.ReadLine();

            return new Quarto(int.Parse(Numero),decimal.Parse(Valor));
        }
        public static Reserva CadastroReserva() 
        {
            RepositorioHospede hospederep = new();
            RepositorioQuarto quartorep = new();
            
            Console.WriteLine("Digite o id do hospede");
            string idhospede = Console.ReadLine();

            Console.WriteLine("Digite o id do quarto");
            string idquarto = Console.ReadLine();


             Hospede novohospede = hospederep.ObterHospede(int.Parse(idhospede));
             Quarto novoquarto = quartorep.ObterQuarto(int.Parse(idquarto));
            if (novoquarto == null || novohospede == null || novoquarto.Ocupacao == true) return null;
            //preguiça de fazer pra colocar as datas bonitinho.
            DateTime checkin = DateTime.Now;
            DateTime checkout = DateTime.Now;

            decimal valortotal = quartorep.CalculaValorTotal(checkin, checkout,novoquarto.Valorpordia);
            quartorep.OcupaQuarto(int.Parse(idquarto));

            return new Reserva(novohospede,novoquarto,checkin,checkout,valortotal);

        }
    }
}
