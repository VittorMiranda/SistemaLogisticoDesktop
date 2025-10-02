using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Logistico.Entidades
{
    public class Motorista
    {
        public int MotoristaId { get; set; }
        public string Nome { get; set; }
        public string CNH { get; set; }
        public string Telefone { get; set; }

        public override string ToString() => $"{Nome} ({CNH})";
    }
}
