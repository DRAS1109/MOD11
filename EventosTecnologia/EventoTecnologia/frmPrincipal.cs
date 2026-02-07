using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class frmPrincipal : Form
    {
        private bool formIniciado = false;

        private bool dgvOrdenado = true;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private Size originalFormSize;
        private Dictionary<Control, Font> originalFonts = new Dictionary<Control, Font>();
        private Dictionary<Control, Rectangle> originalBounds = new Dictionary<Control, Rectangle>();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Dados.Ler();

            dgvDados.ColumnHeaderMouseClick += dgvDados_ColumnHeaderMouseClick;

            // Alterar o tipo de janela
            Text = Dados.appNome + " " + Dados.appVer;

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


            cmbEventos.DataSource = Dados.Eventos;
            cmbEventos.DisplayMember = "Nome";

            if (Dados.Eventos.Count > 0)
            {
                dgvDados.DataSource = Dados.EventoAtual.part;

                if (dgvDados.Rows.Count > 0)
                    dgvDados.Rows[0].Selected = false;

                ConfigurarGrelha();
            }
            else
            {
                dgvDados.DataSource = null;
                dtpData.Value = DateTime.Today;
            }

            chkEditar.Checked = true;


            formIniciado = true;
        }

        private void ConfigurarGrelha()
        {
            // Ocultar coluna IdadeValida e EmailValido
            dgvDados.Columns["IdadeValida"].Visible = false;
            dgvDados.Columns["EmailValido"].Visible = false;

            // Alterar a largura da coluna
            dgvDados.Columns["ID"].Width = 50;
            dgvDados.Columns["Nome"].Width = 150;
            dgvDados.Columns["Idade"].Width = 65;
            dgvDados.Columns["Email"].Width = 172;

            // Formatar o texto da coluna
            dgvDados.Columns["ID"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            dgvDados.Columns["Nome"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            dgvDados.Columns["Idade"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            dgvDados.Columns["Email"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
        }

        private Participante GetAtualDataRown()
        {
            if (dgvDados.CurrentRow == null)
                return null;

            if (!dgvDados.CurrentRow.Selected)
                return null;

            return (Participante)dgvDados.CurrentRow.DataBoundItem;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair da aplicação?", Dados.appNome,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

            return;
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Dados.EventoAtual == null)
                return;

            if (Dados.EventoAtual.part.Count >= (int)nudMaxPart.Value)
            {
                errorProvider.SetError(btnInscrever, "Não pode inscrever mais participantes pois exede a capacidade maxima do evento.");
                return;
            }

            using (frmParticipante form = new frmParticipante(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Dados.EventoAtual.part.Add(form.Part);
                    MessageBox.Show("Novo participante adicionado com sucesso", Dados.appNome,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Dados.Guardar();
            DestacarVIPs();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Dados.EventoAtual == null)
                return;

            if (Dados.EventoAtual.part.Count == 0)
            {
                errorProvider.SetError(btnRemover, "Não existem participantes para remover.");
                return;
            }

            Participante participante = GetAtualDataRown();

            if (participante == null)
            {
                string email = Interaction.InputBox("Introduza o email do participante que deseja remover:", "Remover a partir do email");

                if (email == "")
                    return;

                if (!Participante.IsValidEmail(email))
                {
                    MessageBox.Show("Email inválido.", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (Participante.IsValidEmail(email))
                {
                    bool encontrado = false;

                    for (int i = 0; i < Dados.EventoAtual.part.Count; i++)
                    {
                        if (Dados.EventoAtual.part[i].Email == email)
                        {
                            participante = Dados.EventoAtual.part[i];
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("O email inserido não pertence a nenhum participante", Dados.appNome,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            string msg = $"Deseja remover o participante {participante.Nome}?";

            DialogResult resultado = MessageBox.Show(msg, Dados.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Dados.EventoAtual.part.Remove(participante);

            }
            Dados.Guardar();
            DestacarVIPs();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Dados.EventoAtual == null)
                return;

            if (Dados.EventoAtual.part.Count == 0)
            {
                errorProvider.SetError(btnEditar, "Não existem participantes para editar.");
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
                    MessageBox.Show("Email inválido.", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool encontrado = false;

                for (int i = 0; i < Dados.EventoAtual.part.Count; i++)
                {
                    if (Dados.EventoAtual.part[i].Email == email)
                    {
                        participante = Dados.EventoAtual.part[i];
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("O email inserido não pertence a nenhum participante", Dados.appNome,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            int index = Dados.EventoAtual.part.IndexOf(participante);

            frmParticipante form = new frmParticipante(participante);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Dados.EventoAtual.part[index] = form.Part;
                MessageBox.Show("Participante editado com sucesso", Dados.appNome,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Dados.Guardar();
            DestacarVIPs();
        }

        private void updateChkEditar(bool chk)
        {
            txtRua.Enabled = chk;
            txtCodPostal.Enabled = chk;
            dtpData.Enabled = chk;
            nudMaxPart.Enabled = chk;
            btnInscrever.Enabled = chk;
            btnEditar.Enabled = chk;
            btnRemover.Enabled = chk;
            btnAdicionar.Enabled = chk;
            btnRemoverEvento.Enabled = chk;

            if (chk)
            {
                btnRemover.ForeColor = SystemColors.Desktop;
                btnRemoverEvento.ForeColor = SystemColors.Desktop;
            }
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            updateChkEditar(chkEditar.Checked);
        }

        private void txtRua_Leave(object sender, EventArgs e)
        {
            if (Dados.EventoAtual == null)
                return;

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                errorProvider.SetError(txtRua, "Não pode deixar a rua do evento em branco.");
                txtRua.Text = Dados.EventoAtual.Local.Rua;
                return;
            }

            GuardarAlteracoesEvento();
        }

        private void txtCodPostal_Leave(object sender, EventArgs e)
        {
            if (Dados.EventoAtual == null)
                return;

            errorProvider.Clear();

            if (txtCodPostal.Text == "0000-000")
            {
                errorProvider.SetError(txtCodPostal, "Não pode deixar o código postal em branco.");
                txtCodPostal.Text = Dados.EventoAtual.Local.CodPostal;
                return;
            }

            GuardarAlteracoesEvento();
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

        private void dtpData_CloseUp(object sender, EventArgs e)
        {
            GuardarAlteracoesEvento();
        }

        private void nudMaxPart_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int inscritos = dgvDados.Rows.Count;

            if (dgvDados.DataSource == null || Dados.EventoAtual == null)
                return;

            if (nudMaxPart.Value < inscritos)
            {
                errorProvider.SetError(nudMaxPart, "A capacidade máxima não pode ser inferior ao nº de inscritos.");
                nudMaxPart.Value = inscritos;
                return;
            }
            Dados.EventoAtual.CapacidadeMax = (int)nudMaxPart.Value;

            Dados.Guardar();
            DestacarVIPs();
        }

        private void nudMaxPart_Leave(object sender, EventArgs e)
        {
            GuardarAlteracoesEvento();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chkEditar.Checked)
            {
                // Ignora clique no cabeçalho
                if (e.RowIndex < 0)
                    return;

                btnEditar_Click(sender, EventArgs.Empty);
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre form = new frmSobre();
            form.ShowDialog();
        }

        private void cmbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuardarAlteracoesEvento();

            Evento eventoAtual;

            try
            {
                eventoAtual = (Evento)cmbEventos.SelectedItem;
            }
            catch
            {
                return;
            }

            Dados.EventoAtual = eventoAtual;

            if (eventoAtual == null)
            {
                // Atualiza os campos do evento
                dtpData.Value = DateTime.Today;
                nudMaxPart.Value = 0;
                dgvDados.DataSource = null;
            }

            else
            {
                // Atualiza os campos do evento
                dgvDados.DataSource = null;
                txtRua.Text = eventoAtual.Local.Rua;
                txtCodPostal.Text = eventoAtual.Local.CodPostal;
                dtpData.Value = eventoAtual.Data;
                nudMaxPart.Value = eventoAtual.CapacidadeMax;
                dgvDados.DataSource = eventoAtual.part;

                if (dgvDados.Rows.Count > 0)
                    dgvDados.Rows[0].Selected = false;

                ConfigurarGrelha();
            }

        }

        private void cmbEventos_Leave(object sender, EventArgs e)
        {
            AtualizarNomeEvento();
        }

        private void cmbEventos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarNomeEvento();
                // Indica que a tecla já foi processada e impede que o windows volte a processar
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                cmbEventos.Text = Dados.EventoAtual.Nome;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnRemoverEvento_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (cmbEventos.SelectedItem == null)
            {
                errorProvider.SetError(btnRemoverEvento, "Não tem nenhum evento selecionado.");
                return;
            }

            Evento evento = (Evento)cmbEventos.SelectedItem;

            DialogResult res = MessageBox.Show($"Deseja remover o evento {evento.Nome} e todos os participantes nele inscritos?", Dados.appNome,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res != DialogResult.Yes)
                return;

            Dados.Eventos.Remove(evento);

            if (Dados.Eventos.Count > 0)
            {
                Dados.EventoAtual = Dados.Eventos[0];
                cmbEventos.SelectedItem = Dados.EventoAtual;

                // Atualiza os campos do evento
                dtpData.Value = Dados.EventoAtual.Data;
                nudMaxPart.Value = Dados.EventoAtual.CapacidadeMax;
                dgvDados.DataSource = Dados.EventoAtual.part;
                dgvDados.Rows[0].Selected = false;
                ConfigurarGrelha();
            }
            else
            {
                dgvDados.DataSource = null;
                txtRua.Text = "";
                txtCodPostal.Text = "0000-000";
                nudMaxPart.Value = 2;
                dtpData.Value = DateTime.Today;
            }
            Dados.Guardar();
            DestacarVIPs();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (frmEvento form = new frmEvento())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Dados.Eventos.Add(form.evento);
                    MessageBox.Show("Novo evento adicionado com sucesso", Dados.appNome,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Dados.Guardar();
            DestacarVIPs();
        }

        private void AtualizarNomeEvento()
        {
            string novoNome = cmbEventos.Text.Trim();

            if (Dados.EventoAtual == null)
                return;

            // Atualiza o nome do evento se tiver mudado
            // Verifica se o novo nome não está em branco, se o primeiro caracter é uma letra e se o novo nome é diferente do anterior
            if (!string.IsNullOrEmpty(novoNome.Trim()) && char.IsLetter(novoNome[0]) && novoNome != Dados.EventoAtual.Nome)
            {
                DialogResult res = MessageBox.Show($"Deseja atualizar o nome do evento {Dados.EventoAtual.Nome} para {novoNome}?",
                    Dados.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    Dados.EventoAtual.Nome = novoNome;
                }
                else
                {
                    //Volta ao nome antigo
                    cmbEventos.Text = Dados.EventoAtual.Nome;
                }
            }
            Dados.Guardar();
            DestacarVIPs();
        }

        private void GuardarAlteracoesEvento()
        {
            errorProvider.Clear();

            if (formIniciado == false)
                return;

            if (Dados.EventoAtual == null)
                return;

            // Rua
            Dados.EventoAtual.Local.Rua = txtRua.Text;

            // Codigo Postal
            Dados.EventoAtual.Local.CodPostal = txtCodPostal.Text;

            // Data
            Dados.EventoAtual.Data = dtpData.Value;

            // Capacidade máxima (não pode ser menor que inscritos)
            int inscritos = dgvDados.Rows.Count;

            if (nudMaxPart.Value < inscritos)
            {
                errorProvider.SetError(nudMaxPart, "A capacidade máxima não pode ser inferior ao nº de inscritos.");
                nudMaxPart.Value = inscritos;
                return;
            }

            Dados.EventoAtual.CapacidadeMax = (int)nudMaxPart.Value;

            Dados.Guardar();
            DestacarVIPs();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarAlteracoesEvento();
        }

        private void dgvDados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Dados.EventoAtual == null)
                return;

            // Se a variavel dgvOrdenado estiver a false, torna a True, se estiver a true deixa
            if (dgvOrdenado)
                dgvOrdenado = false;
            else
                dgvOrdenado = true;

            string coluna = dgvDados.Columns[e.ColumnIndex].Name;

            List<Participante> lista = Dados.EventoAtual.part.ToList();

            // Retirado de https://stackoverflow.com/questions/37649028/how-to-sort-datagridview-ascending-and-descending-in-c-sharp
            if (coluna == "ID")
            {
                if (dgvOrdenado)
                    lista = lista.OrderBy(p => p.ID).ToList();
                else
                    lista = lista.OrderByDescending(p => p.ID).ToList();
            }

            if (coluna == "Nome")
            {
                if (dgvOrdenado)
                    lista = lista.OrderBy(p => p.Nome).ToList();
                else
                    lista = lista.OrderByDescending(p => p.Nome).ToList();
            }

            if (coluna == "Idade")
            {
                if (dgvOrdenado)
                    lista = lista.OrderBy(p => p.Idade).ToList();
                else
                    lista = lista.OrderByDescending(p => p.Idade).ToList();
            }

            if (coluna == "Email")
            {
                if (dgvOrdenado)
                    lista = lista.OrderBy(p => p.Email).ToList();
                else
                    lista = lista.OrderByDescending(p => p.Email).ToList();
            }

            // Atualiza BindingList mantendo ordenação
            Dados.EventoAtual.part = new BindingList<Participante>(lista);
            dgvDados.DataSource = Dados.EventoAtual.part;

            // Retirado de https://stackoverflow.com/questions/1193929/datagridviewcolumn-initial-sort-direction
            // Limpa setas de todas as colunas
            foreach (DataGridViewColumn col in dgvDados.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            // Define seta na coluna clicada
            if (dgvOrdenado)
            {
                dgvDados.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
            else
            {
                dgvDados.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            frmEstatisticas form = new frmEstatisticas();
            form.ShowDialog();
        }

        private void btnMostrarVips_Click(object sender, EventArgs e)
        {
            if (Dados.EventoAtual == null || Dados.EventoAtual.part.Count == 0)
            {
                MessageBox.Show("Não há participantes no evento.", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Filtrar apenas os VIPs
            List<ParticipanteVIP> listaVIPs = Dados.EventoAtual.part.OfType<ParticipanteVIP>().ToList();

            if (listaVIPs.Count == 0)
            {
                MessageBox.Show("Não há participantes VIP no evento.", Dados.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensagem = "";
            foreach (ParticipanteVIP vip in listaVIPs)
            {
                mensagem += "\n" + "ID: " + vip.ID + " | Nome: " + vip.Nome + " | Benefícios: " + vip.Beneficios + "\n";
            }

            MessageBox.Show(mensagem, "Participantes VIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DestacarVIPs()
        {
            if (Dados.EventoAtual == null)
                return;

            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                Participante participante = (Participante)row.DataBoundItem;

                if (participante is ParticipanteVIP)
                {
                    // Coluna do ID
                    row.Cells["ID"].Style.BackColor = Color.Yellow;
                }
            }
        }
    }
}