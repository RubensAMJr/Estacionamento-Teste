using Estacionamento.Models.Veiculos;

namespace Estacionamento.Models
{
    public static class EstacionamentoDados
    {
        public static List<Vaga> Vagas { get; set; }

        static EstacionamentoDados()
        {
            Vagas = new List<Vaga>();
        }
    }
}
