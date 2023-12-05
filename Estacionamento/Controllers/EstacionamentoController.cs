using Estacionamento.Models.Enums;
using Estacionamento.Models.Veiculos;
using Estacionamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Estacionamento.Controllers
{
    public class EstacionamentoController
    {
        private readonly IEstacionamentoService _estacionamentoService;
        public EstacionamentoController(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;   
        }

        public string EstacionarVeiculo(TipoVeiculo tipoVeiculo,TipoVaga tipoVaga,string placa)
        {
            return _estacionamentoService.EstacionarVeiculo(tipoVeiculo,tipoVaga,placa);
        }

        public void AdicionarVagasMoto(decimal quantidadeVagasMoto)
        {
            _estacionamentoService.AdicionarVagasMoto(quantidadeVagasMoto);
        }
        public void AdicionarVagasCarro(decimal quantidadeVagasCarro)
        {
            _estacionamentoService.AdicionarVagasCarro(quantidadeVagasCarro);
        }

        public void AdicionarVagasVan(decimal quantidadeVagasVan)
        {
            _estacionamentoService.AdicionarVagasVan(quantidadeVagasVan);
        }

        public string GetVagasRestantes()
        {
            return _estacionamentoService.GetVagasRestantes();
        }

        public string GetVagasTotais()
        {
            return _estacionamentoService.GetVagasTotais();
        }

        public string GetVagasMoto()
        {
            return _estacionamentoService.GetVagas(TipoVaga.Moto).Where(v => v.Veiculo == null).Count().ToString();
        }

        public string GetVagasCarro()
        {
            return _estacionamentoService.GetVagas(TipoVaga.Carro).Where(v => v.Veiculo == null).Count().ToString();
        }

        public string GetVagasVan()
        {
            return _estacionamentoService.GetVagas(TipoVaga.Van).Where(v => v.Veiculo == null).Count().ToString();
        }

        public string GetVagasOcupadasVans()
        {
            return (_estacionamentoService.GetVagas(TipoVaga.Van).Where(v => v.Veiculo != null).Count() +
                   _estacionamentoService.GetVagas(TipoVaga.Carro).Where(v => v.Veiculo != null && v.Veiculo.GetType() == typeof(Van)).Count()).ToString();
        }
    }
}
