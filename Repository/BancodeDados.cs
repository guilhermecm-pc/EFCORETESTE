using EFCORETESTE.Models.Models.Host;
using EFCORETESTE.Models.Models.room;
using EFCORETESTE.Models.Models.Reserva;
using Hotelfinalproject.Models.Models.Report;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORETESTE.Repository
{
    public class Hotel_Dbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=EFHotel;Trusted_Connection=True");
        }
        public DbSet<Quarto> quartos { get; set; }
        public DbSet<Hospede> hospedes { get; set; }
        public DbSet<Reserva> reservade { get; set; }
        public DbSet<RelatorioOcupacao> ocupacao { get; set; }
        public DbSet<RelatorioFaturamento> faturamento  { get; set; }
    }
}
