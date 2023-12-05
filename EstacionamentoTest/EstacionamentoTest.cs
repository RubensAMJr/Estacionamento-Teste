using Estacionamento.Services;
using Estacionamento.Models;
using Estacionamento.Models.Enums;

namespace EstacionamentoTest
{
    public class EstacionamentoTest
    {
        protected readonly EstacionamentoService _estacionamentoService;

        public EstacionamentoTest()
        {
            _estacionamentoService = new EstacionamentoService();
            EstacionamentoDados.Vagas = new List<Vaga>();
        }

        [Fact]
        public void AdicionarVagasMotoTest()
        {
            _estacionamentoService.AdicionarVagasMoto(5);
            Assert.NotEmpty(EstacionamentoDados.Vagas);
        }

        [Fact]
        public void AdicionarVagasCarroTest()
        {
            _estacionamentoService.AdicionarVagasCarro(5);
            Assert.NotEmpty(EstacionamentoDados.Vagas);
        }

        [Fact]
        public void AdicionarVagasVanTest()
        {
           _estacionamentoService.AdicionarVagasVan(5);
           Assert.NotEmpty(EstacionamentoDados.Vagas);
        }

        [Fact]
        public void GetVagasRestantesTest()
        {
            _estacionamentoService.AdicionarVagasCarro(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var vagasRestantes = _estacionamentoService.GetVagasRestantes();
            Assert.Equal("10",vagasRestantes);
        }

        [Fact]
        public void GetVagasTotaisTest()
        {
            _estacionamentoService.AdicionarVagasCarro(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var vagasTotais = _estacionamentoService.GetVagasTotais();
            Assert.Equal("10", vagasTotais);
        }

        [Fact]
        public void EstacionarCarroTest()
        {
            string placa = "ABC-1234";
            _estacionamentoService.AdicionarVagasCarro(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var status = _estacionamentoService.EstacionarVeiculo(TipoVeiculo.Carro,TipoVaga.Carro,"ABC-1234");

            Assert.Equal("9", _estacionamentoService.GetVagasRestantes());
            Assert.Equal($"Carro com a placa {placa} estacionado com sucesso!",status);
        }

        [Fact]
        public void EstacionarMotoTest()
        {
            string placa = "ABC-1234";
            _estacionamentoService.AdicionarVagasMoto(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var status = _estacionamentoService.EstacionarVeiculo(TipoVeiculo.Moto, TipoVaga.Moto, "ABC-1234");

            Assert.Equal("9", _estacionamentoService.GetVagasRestantes());
            Assert.Equal($"Moto com a placa {placa} estacionada com sucesso!", status);
        }

        [Fact]
        public void EstacionarVanTest()
        {
            string placa = "ABC-1234";
            _estacionamentoService.AdicionarVagasCarro(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var status = _estacionamentoService.EstacionarVeiculo(TipoVeiculo.Van, TipoVaga.Van, "ABC-1234");

            Assert.Equal("9", _estacionamentoService.GetVagasRestantes());
            Assert.Equal($"Van com a placa {placa} estacionada com sucesso!", status);
        }

        [Fact]
        public void EstacionarVanEmVagaDeCarroTest()
        {
            string placa = "ABC-1234";
            _estacionamentoService.AdicionarVagasCarro(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var status = _estacionamentoService.EstacionarVeiculo(TipoVeiculo.Van, TipoVaga.Carro, "ABC-1234");

            Assert.Equal("7", _estacionamentoService.GetVagasRestantes());
            Assert.Equal($"Van com a placa {placa} estacionada com sucesso!", status);
        }

        [Fact]
        public void EstacionarCarroEmVagaDeMotoTest()
        {
            string placa = "ABC-1234";
            _estacionamentoService.AdicionarVagasCarro(5);
            _estacionamentoService.AdicionarVagasMoto(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var status = _estacionamentoService.EstacionarVeiculo(TipoVeiculo.Carro, TipoVaga.Moto, "ABC-1234");

            Assert.Equal($"Carros não podem estacionar em vagas de moto", status);
        }

        [Fact]
        public void EstacionarVanEmVagaDeMotoTest()
        {
            string placa = "ABC-1234";
            _estacionamentoService.AdicionarVagasCarro(5);
            _estacionamentoService.AdicionarVagasMoto(5);
            _estacionamentoService.AdicionarVagasVan(5);
            var status = _estacionamentoService.EstacionarVeiculo(TipoVeiculo.Van, TipoVaga.Moto, "ABC-1234");

            Assert.Equal($"Vans não podem estacionar em vagas de moto", status);
        }
    }
}