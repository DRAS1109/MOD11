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
    public partial class frmParticipante : Form
    {
        public Participante Part { get; private set; }

        public frmParticipante(Participante _part)
        {
            InitializeComponent();

            if (_part != null)
            {
                txtNome.Text = _part.Nome;
                txtEmail.Text = _part.Email;
                nudIdade.Value = _part.Idade;
            }

            Part = _part;

            // Se clicar ENTER ou no botão OK, assume a ação OK
            AcceptButton = btnOk;

            // Se clicar ESQ ou no botão Cancelar, assume a ação Cancel
            CancelButton = btnCancelar;

            // Ignorar a validação dos dados caso click no botão cancelar
            btnCancelar.CausesValidation = false;

            // Fecha a janela e retorna a mensagem da ação correspondente
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        // Botão Ok
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEmail.Text != "")
            {
                Participante p;

                if (nudIdade.Value != 0)
                    p = new Participante(txtNome.Text, (int)nudIdade.Value, txtEmail.Text);

                else
                    p = new Participante(txtNome.Text, txtEmail.Text);

                // Verificações
                if (p.IdadeValida == false)
                {
                    MessageBox.Show("Idade inválida, deve ser maior ou igual a 16 anos");
                    return;
                }

                if (p.EmailValido == false)
                {
                    MessageBox.Show("Email inválido");
                    return;
                }

                // Adiciona o novo participante e volta ao forms principal
                Part = p;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show("Deve preencher todos os dados");
                return;
            }
        }
    }
}
