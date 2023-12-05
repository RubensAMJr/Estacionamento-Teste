using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models.Veiculos
{
    public class Moto : Veiculo
    {
        public Moto(string placa)
        {
            this.Placa = placa;                
        }
    }
}
