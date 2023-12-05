using Estacionamento.Models;
using Estacionamento.Models.Enums;
using Estacionamento.Models.Veiculos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class EstacionamentoService : IEstacionamentoService
    {
        public string EstacionarVeiculo(TipoVeiculo tipoVeiculo, TipoVaga tipoVaga, string placa)
        {
            switch (tipoVeiculo)
            {
                case TipoVeiculo.Moto:
                    return EstacionarMoto(tipoVaga, placa);

                case TipoVeiculo.Carro:
                   if (tipoVaga == TipoVaga.Moto)
                       return "Carros não podem estacionar em vagas de moto";
                   else
                       return EstacionarCarro(tipoVaga,placa);

                case TipoVeiculo.Van:
                    if (tipoVaga == TipoVaga.Moto)
                       return "Vans não podem estacionar em vagas de moto";
                   else
                       return EstacionarVan(tipoVaga, placa);

                default:
                    return "Tipo de veículo Invalido";
            }
        }
        private string EstacionarMoto(TipoVaga tipoVaga, string placa)
        {
            var novoVeiculo = new Moto(placa);
            var veiculoVaga = EstacionamentoDados.Vagas.FirstOrDefault(v => v.Veiculo == null && v.TipoVaga == tipoVaga);

            if (veiculoVaga != null)
            {
                veiculoVaga.Veiculo = novoVeiculo;
                return $"Moto com a placa {placa} estacionada com sucesso!";
            }

            return "Não foi encontrado uma vaga compatível com o veículo";
        }

        private string EstacionarCarro(TipoVaga tipoVaga, string placa)
        {
            var novoVeiculo = new Carro(placa);
            var veiculoVaga = EstacionamentoDados.Vagas.FirstOrDefault(v => v.Veiculo == null && v.TipoVaga == tipoVaga);

            if (veiculoVaga != null)
            {
                veiculoVaga.Veiculo = novoVeiculo;
                return $"Carro com a placa {placa} estacionado com sucesso!";
            }

            return "Não foi encontrado uma vaga compatível com o veículo";
        }

        private string EstacionarVan(TipoVaga tipoVaga, string placa) 
        {
            var novoVeiculo = new Van(placa);

            if (tipoVaga.Equals(TipoVaga.Carro))
            {
                var veiculoVagas = EstacionamentoDados.Vagas.Where(v => v.Veiculo == null && v.TipoVaga == TipoVaga.Carro).Take(3);
                if (veiculoVagas == null || veiculoVagas.Count() < 3)
                    return "Não foi possivel estacionar a van em vagas de carro por indisponíbilidade de 3 vagas necessárias";
                else
                {
                    foreach (var vaga in veiculoVagas)
                        vaga.Veiculo = novoVeiculo;
                    return $"Van com a placa {placa} estacionada com sucesso!";
                }
            }
            else
            {
                var veiculoVaga = EstacionamentoDados.Vagas.FirstOrDefault(v => v.Veiculo == null && v.TipoVaga == tipoVaga);
                if (veiculoVaga != null)
                {
                    veiculoVaga.Veiculo = novoVeiculo;
                    return $"Van com a placa {placa} estacionada com sucesso!";
                }
                else
                    return "Não foi encontrado uma vaga compatível com o veículo";
            }
        }

        public void AdicionarVagasMoto(decimal quantidadeVagasMoto)
        {
            for (int i = 0; i < quantidadeVagasMoto; i++)
                EstacionamentoDados.Vagas.Add(new Vaga(TipoVaga.Moto));
        }

        public void AdicionarVagasCarro(decimal quantidadeVagasCarro)
        {
            for (int i = 0; i < quantidadeVagasCarro; i++)
                EstacionamentoDados.Vagas.Add(new Vaga(TipoVaga.Carro));
        }

        public void AdicionarVagasVan(decimal quantidadeVagasVan)
        {
            for (int i = 0; i < quantidadeVagasVan; i++)
                EstacionamentoDados.Vagas.Add(new Vaga(TipoVaga.Van));
        }

        public string GetVagasRestantes()
        {
            return EstacionamentoDados.Vagas.Where(v => v.Veiculo == null).Count().ToString();
        }

        public string GetVagasTotais()
        {
            return EstacionamentoDados.Vagas.Count().ToString();
        }

        public List<Vaga> GetVagas(TipoVaga vaga)
        {
            return EstacionamentoDados.Vagas.Where(v => v.TipoVaga == vaga).ToList();
        }
    }
}
