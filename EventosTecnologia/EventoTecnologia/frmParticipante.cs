using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    public partial class frmParticipante : Form
    {
        public Participante Part { get; private set; }

        public frmParticipante(Participante _part)
        {
            InitializeComponent();

            Part = _part;

            if (Part == null)
            {
                lblID.Visible = false;
                txtID.Visible = false;
            }

            if (Part != null)
            {
                txtID.Text = Part.ID.ToString();
                txtNome.Text = Part.Nome;
                txtEmail.Text = Part.Email;
                nudIdade.Value = Part.Idade;

                if (Part is ParticipanteVIP)
                    chkVIP.Checked = true;
            }

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
            if (ValidarDados() == false)
                return;

            Participante p;

            // Verificar se já existe um VIP e pegar benefícios atuais
            string beneficiosAtuais = "";

            if (Part is ParticipanteVIP vip)
            {
                beneficiosAtuais = vip.Beneficios;
            }

            if (txtID.Text == "")
            {
                if (chkVIP.Checked)
                {

                    // Pedir benefícios
                    string beneficios = Microsoft.VisualBasic.Interaction.InputBox(
                        "Indique os benefícios do participante VIP:", "Benefícios VIP", beneficiosAtuais);

                    if (nudIdade.Value != 0)
                        p = new ParticipanteVIP(txtNome.Text, (int)nudIdade.Value, txtEmail.Text, beneficios);

                    else
                        p = new ParticipanteVIP(txtNome.Text, txtEmail.Text, beneficios);
                }

                else
                {
                    if (nudIdade.Value != 0)
                        p = new Participante(txtNome.Text, (int)nudIdade.Value, txtEmail.Text);

                    else
                        p = new Participante(txtNome.Text, txtEmail.Text);
                }
            }

            else
            {
                if (chkVIP.Checked)
                {
                    // Pedir benefícios
                    string beneficios = Microsoft.VisualBasic.Interaction.InputBox(
                        "Indique os benefícios do participante VIP:", "Benefícios VIP", beneficiosAtuais);

                    if (nudIdade.Value != 0)
                        p = new ParticipanteVIP(int.Parse(txtID.Text), txtNome.Text, (int)nudIdade.Value, txtEmail.Text, beneficios);

                    else
                        p = new ParticipanteVIP(int.Parse(txtID.Text), txtNome.Text, txtEmail.Text, beneficios);
                }

                else
                {
                    if (nudIdade.Value != 0)
                        p = new Participante(int.Parse(txtID.Text), txtNome.Text, (int)nudIdade.Value, txtEmail.Text);

                    else
                        p = new Participante(int.Parse(txtID.Text), txtNome.Text, txtEmail.Text);
                } 
            }

            // Adiciona o novo participante e volta ao forms principal
            Part = p;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidarDados()
        {
            bool valido = true;

            errorProvider.Clear();

            // Nome
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Deve preencher o nome do participante.");
                valido = false;
            }

            // Email vazio
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail,"Deve preencher o email.");
                valido = false;
            }
            else if (!Participante.IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail,"Introduza um email válido.");
                valido = false;
            }

            // Idade
            if (nudIdade.Value < 16 && nudIdade.Value != 0)
            {
                errorProvider.SetError(nudIdade,"A idade deve ser maior ou igual a 16 anos.");
                valido = false;
            }

            return valido;
        }

        private void frmParticipante_Load(object sender, EventArgs e)
        {

        }
    }
}
