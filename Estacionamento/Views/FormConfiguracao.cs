using Estacionamento.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Views
{
    public partial class FormConfiguracao : Form
    {
        private readonly EstacionamentoController _estacionamentoController;
        private readonly FormEstacionamento _formEstacionamento;

        public FormConfiguracao(EstacionamentoController estacionamentoController, FormEstacionamento formEstacionamento)
        {
            InitializeComponent();
            _estacionamentoController = estacionamentoController;
            _formEstacionamento = formEstacionamento;
        }

        private void btn_inicializar_Click(object sender, EventArgs e)
        {
            _estacionamentoController.AdicionarVagasMoto(quantidadeVagasMoto.Value);
            _estacionamentoController.AdicionarVagasCarro(quantidadeVagasCarro.Value);
            _estacionamentoController.AdicionarVagasVan(quantidadeVagasVan.Value);
            this.Hide();
            _formEstacionamento.InicializarCampos();
            _formEstacionamento.InicializarComboBox();
            _formEstacionamento.Show();
        }
    }
}
