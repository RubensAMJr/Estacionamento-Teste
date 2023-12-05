using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models.Veiculos
{
    public class Carro: Veiculo
    {
        public Carro(string placa)
        {
            this.Placa = placa;
        }
    }
}
