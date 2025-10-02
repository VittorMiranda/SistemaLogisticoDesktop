using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Logistico.Entidades
{
    public class Viagem
    {
        public int ViagemId { get; set; }
        public int MotoristaId { get; set; }
        public int VeiculoId { get; set; }
        public int RotaId { get; set; }
        public string Situacao { get; set; } 
        public DateTime DataSaida { get; set; }
        public DateTime? DataChegada { get; set; } 
        public bool Ativo { get; set; } = true;
        public string MotoristaNome { get; set; } 
        public string VeiculoNome { get; set; }   
        public string RotaNome { get; set; }      
        public Viagem() { }

        public Viagem(int viagemId, int motoristaId, int veiculoId, int rotaId, string situacao,
                      DateTime dataSaida, DateTime? dataChegada, bool ativo = true)
        {
            ViagemId = viagemId;
            MotoristaId = motoristaId;
            VeiculoId = veiculoId;
            RotaId = rotaId;
            Situacao = situacao;
            DataSaida = dataSaida;
            DataChegada = dataChegada;
            Ativo = ativo;
        }

        public override string ToString() =>
            $"Viagem #{ViagemId} - Veículo {VeiculoId} / Motorista {MotoristaId} ({Situacao})";


    }
}
