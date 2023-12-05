using Estacionamento.Models.Enums;
using Estacionamento.Models.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Vaga
    {
        public Vaga(TipoVaga tipo)
        {
            TipoVaga = tipo;                
        }
        public Veiculo? Veiculo { get; set; }
        public TipoVaga TipoVaga { get; set; }
    }
}