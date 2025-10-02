using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Logistico.Entidades
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public decimal ConsumoMedio { get; set; }
        public decimal CargaMaxima { get; set; }

        public Veiculo() { }

        internal Veiculo(int id, string modelo, string placa, decimal consumo, decimal carga)
        {
            VeiculoId = id;
            Modelo = modelo;
            Placa = placa;
            ConsumoMedio = consumo;
            CargaMaxima = carga;
        }

        public override string ToString() => $"{Modelo} ({Placa})";
    }
}
