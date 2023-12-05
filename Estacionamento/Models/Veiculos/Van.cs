using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models.Veiculos
{
    public class Van : Veiculo
    {
        public Van(string placa)
        {
            this.Placa = placa;                
        }
    }
}
