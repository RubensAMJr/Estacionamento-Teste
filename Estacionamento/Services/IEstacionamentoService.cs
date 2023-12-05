using Estacionamento.Models;
using Estacionamento.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public interface IEstacionamentoService
    {
        public void AdicionarVagasMoto(decimal quantidadeVagasMoto);
        public void AdicionarVagasCarro(decimal quantidadeVagasCarro);
        public void AdicionarVagasVan(decimal quantidadeVagasVan);
        public string EstacionarVeiculo(TipoVeiculo tipoVeiculo, TipoVaga tipoVaga, string placa);
        public string GetVagasRestantes();
        public string GetVagasTotais();
        public List<Vaga> GetVagas(TipoVaga vaga);
    }
}
