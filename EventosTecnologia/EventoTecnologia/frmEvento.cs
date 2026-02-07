using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class frmEvento : Form
    {
        public Evento evento;

        public frmEvento()
        {
            InitializeComponent();

            // Se clicar ENTER ou no botão OK, assume a ação OK
            AcceptButton = btnOk;

            // Se clicar ESQ ou no botão Cancelar, assume a ação Cancel
            CancelButton = btnCancelar;

            // Ignorar a validação dos dados caso click no botão cancelar
            btnCancelar.CausesValidation = false;

            // Fecha a janela e retorna a mensagem da ação correspondente
            btnCancelar.DialogResult = DialogResult.Cancel;

            dtpData.Value = DateTime.Today;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            evento = new Evento(txtNome.Text, dtpData.Value, (int)nudMaxPart.Value, new Localizacao(txtRua.Text, txtCodPostal.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidarDados()
        {
            bool valido = true;

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Deve preencher o nome do evento.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                errorProvider.SetError(txtRua, "Deve preencher a rua do evento.");
                valido = false;
            }

            if (txtCodPostal.Text == "0000-000")
            {
                errorProvider.SetError(txtCodPostal, "Deve preencher o código postal do evento.");
                valido = false;
            }

            return valido;
        }

    }
}
