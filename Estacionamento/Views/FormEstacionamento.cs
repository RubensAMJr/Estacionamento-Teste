using Estacionamento.Controllers;
using Estacionamento.Models;
using Estacionamento.Models.Enums;
using System.Security.Policy;

namespace Estacionamento
{
    public partial class FormEstacionamento : Form
    {
        private readonly EstacionamentoController _estacionamentoController;
        public FormEstacionamento(EstacionamentoController estacionamentoController)
        {
            _estacionamentoController = estacionamentoController;
            InitializeComponent();
        }

        public void InicializarCampos()
        {
            labelQuantidadeVagasRestantes.Text = _estacionamentoController.GetVagasRestantes();
            labelQuantidadeVagasTotais.Text = _estacionamentoController.GetVagasTotais();
            lblQuantidadeVagasMoto.Text = _estacionamentoController.GetVagasMoto();
            lblQuantidadeVagasCarro.Text = _estacionamentoController.GetVagasCarro();
            lblQuantidadeVagasVan.Text = _estacionamentoController.GetVagasVan();
            lblQuantidadeVagasOcupadasVans.Text = _estacionamentoController.GetVagasOcupadasVans();
        }

        public void InicializarComboBox()
        {
            foreach (string nome in Enum.GetNames(typeof(TipoVeiculo)))
                CBTipoVeiculo.Items.Add(nome);

            foreach (string nome in Enum.GetNames(typeof(TipoVaga)))
                CBTipoVaga.Items.Add(nome);
        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            var status = _estacionamentoController.EstacionarVeiculo((TipoVeiculo)Enum.Parse(typeof(TipoVeiculo), CBTipoVeiculo.Text, true),
                                                                     (TipoVaga)Enum.Parse(typeof(TipoVaga), CBTipoVaga.Text, true),
                                                                     PlacaVeiculo.Text);

            InicializarCampos();
            var vagasRestantes = _estacionamentoController.GetVagasRestantes();

            if (vagasRestantes.Equals("0"))
                MessageBox.Show("Não há mais vagas restantes!");
            else
                MessageBox.Show(status);
        }
    }
}
