using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Logistico.Entidades
{
    public class Rota
    {
        public int RotaId { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public decimal Distancia { get; set; }

        public override string ToString() => $"{Origem} → {Destino} ({Distancia} km)";
        // Propriedade auxiliar para exibir no ComboBox
        public string Descricao => $"{Origem} >> {Destino}";
    }
}
