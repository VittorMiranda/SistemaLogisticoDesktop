using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Logistico.Entidades
{
    internal class PrecoCombustivel
    {
        public int PrecoId { get; set; }
        public string Combustivel { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataConsulta { get; set; } = DateTime.Now;

        public override string ToString() => $"{Combustivel}: R$ {Preco:0.00} ({DataConsulta:dd/MM/yyyy})";
    }
}
