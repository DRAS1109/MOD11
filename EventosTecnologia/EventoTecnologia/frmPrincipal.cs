using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Alterar o tipo de janela
            Text = Dados.appNome + " " + Dados.appVer;
            dgvDados.DataSource = Dados.evento.part;

            // Aplica a seleção para toda a linha
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Desativar seleção multipla de linhas
            dgvDados.MultiSelect = false;

            // Esconder o cabeçalho da linha
            dgvDados.RowHeadersVisible = false;

            // Aplicar a DataGridView apenas para leitura
            dgvDados.ReadOnly = true;

            // Não tem permissão para adicionar uma nova linha
            dgvDados.AllowUserToAddRows = false;

            // Não tem permissão para remover uma linha
            dgvDados.AllowUserToDeleteRows = false;

            // Não permite redimensionar a altura das linhas
            dgvDados.AllowUserToResizeRows = false;

            // Não permite redimensionar a largura das colunas
            dgvDados.AllowUserToResizeColumns = false;

            dgvDados.DataSource = Dados.evento.part;
            txtNome.Text = Dados.NomeEvento;
            dtpData.Value = Dados.DataEvento;
            nudMaxPart.Value = Dados.CapMaxEvento;


            // Ocultar coluna IdadeValida e EmailValido
            chkEditar.Checked = true;
            dgvDados.Columns["IdadeValida"].Visible = false;
            dgvDados.Columns["EmailValido"].Visible = false;

            // Alterar a largura da coluna
            dgvDados.Columns["Nome"].Width = 190;
            dgvDados.Columns["Idade"].Width = 50;
            dgvDados.Columns["Email"].Width = 196;

            // Formatar o texto da coluna
            dgvDados.Columns["Nome"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            dgvDados.Columns["Idade"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            dgvDados.Columns["Email"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);

            AtualNPart();
        }

        private Participante GetAtualDataRown()
        {
            if (dgvDados.SelectedRows.Count > 0)
                return (Participante)dgvDados.CurrentRow.DataBoundItem;
            else
                return null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            if (Dados.evento.part.Count >= (int)nudMaxPart.Value)
            {
                MessageBox.Show("Não pode inscrever mais participantes pois exede a capacidade maxima do evento", 
                    Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmParticipante form = new frmParticipante(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Dados.evento.part.Add(form.Part);
                    MessageBox.Show("Novo participante adicionado com sucesso", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualNPart();
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count > 0)
            {
                Participante dados = GetAtualDataRown();

                //Se estiver algum selecionado
                if (dados != null)
                {
                    int selecionado = Dados.evento.part.IndexOf(dados);
                    string msg = "Deseja remover o participante " + dados.Nome + "?";

                    DialogResult resultado = MessageBox.Show(msg, Dados.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                        Dados.evento.part.RemoveAt(selecionado);
                }

                else
                {
                    string Pergunta = "Introduza o email do participante que deseja remover:";
                    string email = Interaction.InputBox(Pergunta, "Remover a partir do email");

                    if (email == "")
                        return;

                    if (Participante.IsValidEmail(email))
                    {
                        int encontrado = -1;

                        for (int i = 0; i < Dados.evento.part.Count; i++)
                        {
                            if (Dados.evento.part[i].Email == email)
                            {
                                encontrado = i;
                                break;
                            }
                        }

                        if (encontrado != -1)
                        {
                            Console.WriteLine("E-mail encontrado!");

                            string msg = "Deseja remover o participante " + Dados.evento.part[encontrado].Nome + "?";

                            DialogResult resultado = MessageBox.Show(msg, Dados.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                                Dados.evento.part.RemoveAt(encontrado);
                        }

                        else
                            MessageBox.Show("O email inserido não pertence a nenhum participante");
                    }

                    else
                        MessageBox.Show("Email inválido.");
                }
            }

            else
                MessageBox.Show("Não existem participantes para remover.", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            AtualNPart();
        }

        private void ConfirmarERemover(Participante participante)
        {
            string msg = $"Deseja remover o participante {participante.Nome}?";

            DialogResult resultado = MessageBox.Show(msg, Dados.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Dados.evento.part.Remove(participante);
                AtualNPart();
            }
        }


        private void updateChkEditar(bool chk)
        {
            txtNome.Enabled = chk;
            dtpData.Enabled = chk;
            nudMaxPart.Enabled = chk;
            btnInscrever.Enabled = chk;
            btnRemover.Enabled = chk;
            btnEditar.Enabled = chk;
            btnRemoverEvento.Enabled = chk;
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            updateChkEditar(chkEditar.Checked);
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            // Se o evento já passou
            if (dtpData.Value.Date < DateTime.Today)
            {
                updateChkEditar(false);

                // Desabilita a chkEditar
                chkEditar.Enabled = false;

                // A data do evento pode ser alterada
                dtpData.Enabled = true;
            }

            else
            {
                updateChkEditar(true);
                chkEditar.Enabled = true;
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre form = new frmSobre();
            form.ShowDialog();
        }

        private void AtualNPart()
        {
            txtNPart.Text = dgvDados.RowCount.ToString();
        }

        private void nudMaxPart_ValueChanged(object sender, EventArgs e)
        {
            int linhas = dgvDados.RowCount;

            if (nudMaxPart.Value < linhas)
            {
                nudMaxPart.Value = linhas;
                MessageBox.Show("O valor não pode ser menor que o número de registos.", "Valor inválido");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Dados.evento.part.Count == 0)
            {
                MessageBox.Show("Não existem participantes para editar.", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Participante participante = GetAtualDataRown();

            if (participante == null)
            {
                string email = Interaction.InputBox("Introduza o email do participante que deseja editar:", "Editar a partir do email");

                if (string.IsNullOrWhiteSpace(email))
                    return;

                if (!Participante.IsValidEmail(email))
                {
                    MessageBox.Show("Email inválido.");
                    return;
                }

                int encontrado = -1;

                for (int i = 0; i < Dados.evento.part.Count; i++)
                {
                    if (Dados.evento.part[i].Email == email)
                    {
                        participante = Dados.evento.part[i];
                        break;
                    }
                }
            }

            EditarParticipante(participante);
        }

        private void EditarParticipante(Participante participante)
        {
            int index = Dados.evento.part.IndexOf(participante);

            frmParticipante form = new frmParticipante(participante);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Dados.evento.part[index] = form.Part;
                MessageBox.Show("Participante editado com sucesso", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora clique no header
            if (e.RowIndex < 0)
                return;

            btnEditar_Click(sender, EventArgs.Empty);
        }
    }
}
