namespace EventoTecnologia
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblEventos = new Label();
            lblData = new Label();
            lblMaxPart = new Label();
            chkEditar = new CheckBox();
            dtpData = new DateTimePicker();
            grpPart = new GroupBox();
            btnEditar = new Button();
            btnInscrever = new Button();
            btnRemover = new Button();
            dgvDados = new DataGridView();
            nudMaxPart = new NumericUpDown();
            btnSair = new Button();
            btnSobre = new Button();
            btnRemoverEvento = new Button();
            toolTip = new ToolTip(components);
            cmbEventos = new ComboBox();
            btnAdicionar = new Button();
            txtRua = new TextBox();
            txtCodPostal = new TextBox();
            errorProvider = new ErrorProvider(components);
            lblRua = new Label();
            lblCodPostal = new Label();
            btnEstatisticas = new Button();
            btnMostrarVips = new Button();
            grpPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblEventos
            // 
            lblEventos.AutoSize = true;
            lblEventos.Location = new Point(40, 30);
            lblEventos.Name = "lblEventos";
            lblEventos.Size = new Size(48, 15);
            lblEventos.TabIndex = 13;
            lblEventos.Text = "Eventos";
            // 
            // lblData
            // 
            lblData.Location = new Point(40, 110);
            lblData.Name = "lblData";
            lblData.Size = new Size(48, 15);
            lblData.TabIndex = 13;
            lblData.Text = "Data";
            // 
            // lblMaxPart
            // 
            lblMaxPart.AutoSize = true;
            lblMaxPart.Location = new Point(322, 110);
            lblMaxPart.Name = "lblMaxPart";
            lblMaxPart.Size = new Size(118, 15);
            lblMaxPart.TabIndex = 13;
            lblMaxPart.Text = "Nº Máx Participantes";
            // 
            // chkEditar
            // 
            chkEditar.AutoSize = true;
            chkEditar.Location = new Point(545, 109);
            chkEditar.Name = "chkEditar";
            chkEditar.Size = new Size(95, 19);
            chkEditar.TabIndex = 7;
            chkEditar.Text = "Editar Evento";
            toolTip.SetToolTip(chkEditar, "Marque ou desmarque para ativar/desativar a edição dos campos");
            chkEditar.UseVisualStyleBackColor = true;
            chkEditar.CheckedChanged += chkEditar_CheckedChanged;
            // 
            // dtpData
            // 
            dtpData.CalendarMonthBackground = Color.White;
            dtpData.Location = new Point(94, 106);
            dtpData.MinDate = new DateTime(1809, 9, 11, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(190, 23);
            dtpData.TabIndex = 5;
            toolTip.SetToolTip(dtpData, "Escolha a data do evento");
            dtpData.Value = new DateTime(2026, 2, 5, 12, 0, 19, 0);
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // grpPart
            // 
            grpPart.Controls.Add(btnEditar);
            grpPart.Controls.Add(btnInscrever);
            grpPart.Controls.Add(btnRemover);
            grpPart.Controls.Add(dgvDados);
            grpPart.Font = new Font("Segoe UI", 9F);
            grpPart.ForeColor = Color.FromArgb(46, 46, 46);
            grpPart.Location = new Point(40, 160);
            grpPart.Name = "grpPart";
            grpPart.Size = new Size(600, 203);
            grpPart.TabIndex = 6;
            grpPart.TabStop = false;
            grpPart.Text = "Participantes";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.ForeColor = SystemColors.ControlText;
            btnEditar.Location = new Point(475, 85);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 40);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "&Editar";
            toolTip.SetToolTip(btnEditar, "Clique para editar o participante selecionado");
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInscrever
            // 
            btnInscrever.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInscrever.ForeColor = SystemColors.ControlText;
            btnInscrever.Location = new Point(475, 30);
            btnInscrever.Name = "btnInscrever";
            btnInscrever.Size = new Size(100, 40);
            btnInscrever.TabIndex = 8;
            btnInscrever.Text = "&Increver";
            toolTip.SetToolTip(btnInscrever, "Clique para inscrever um novo participante.");
            btnInscrever.UseVisualStyleBackColor = true;
            btnInscrever.Click += btnInscrever_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.WhiteSmoke;
            btnRemover.Font = new Font("Segoe UI", 9F);
            btnRemover.ForeColor = SystemColors.Desktop;
            btnRemover.Location = new Point(475, 140);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 40);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "&Remover";
            toolTip.SetToolTip(btnRemover, "Clique para remover o participante selecionado");
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(30, 30);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(440, 150);
            dgvDados.TabIndex = 13;
            dgvDados.TabStop = false;
            toolTip.SetToolTip(dgvDados, "Lista de participantes do evento\r\nClique duplo para editar");
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // nudMaxPart
            // 
            nudMaxPart.BackColor = Color.White;
            nudMaxPart.Location = new Point(446, 106);
            nudMaxPart.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudMaxPart.Name = "nudMaxPart";
            nudMaxPart.Size = new Size(60, 23);
            nudMaxPart.TabIndex = 6;
            toolTip.SetToolTip(nudMaxPart, "Defina a capacidade máxima de participantes do evento");
            nudMaxPart.ValueChanged += nudMaxPart_ValueChanged;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(555, 376);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(85, 23);
            btnSair.TabIndex = 12;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnSobre
            // 
            btnSobre.Location = new Point(121, 376);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(85, 23);
            btnSobre.TabIndex = 11;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = true;
            btnSobre.Click += btnSobre_Click;
            // 
            // btnRemoverEvento
            // 
            btnRemoverEvento.BackColor = Color.WhiteSmoke;
            btnRemoverEvento.Font = new Font("Segoe UI", 9F);
            btnRemoverEvento.ForeColor = SystemColors.Desktop;
            btnRemoverEvento.Location = new Point(545, 27);
            btnRemoverEvento.Name = "btnRemoverEvento";
            btnRemoverEvento.Size = new Size(95, 23);
            btnRemoverEvento.TabIndex = 2;
            btnRemoverEvento.Text = "Remover";
            toolTip.SetToolTip(btnRemoverEvento, "Clique para remover o evento selecionado e todos os seus participantes");
            btnRemoverEvento.UseVisualStyleBackColor = true;
            btnRemoverEvento.Click += btnRemoverEvento_Click;
            // 
            // cmbEventos
            // 
            cmbEventos.BackColor = Color.White;
            cmbEventos.FormattingEnabled = true;
            cmbEventos.Location = new Point(94, 27);
            cmbEventos.Name = "cmbEventos";
            cmbEventos.Size = new Size(315, 23);
            cmbEventos.TabIndex = 0;
            toolTip.SetToolTip(cmbEventos, "Selecione o evento para visualizar ou editar participantes\r\nSe editar o nome prima Enter para guardar");
            cmbEventos.SelectedIndexChanged += cmbEventos_SelectedIndexChanged;
            cmbEventos.KeyDown += cmbEventos_KeyDown;
            cmbEventos.Leave += cmbEventos_Leave;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.WhiteSmoke;
            btnAdicionar.Font = new Font("Segoe UI", 9F);
            btnAdicionar.ForeColor = SystemColors.ControlText;
            btnAdicionar.Location = new Point(430, 27);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(95, 23);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            toolTip.SetToolTip(btnAdicionar, "Clique para adicionar um novo evento");
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(94, 67);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(375, 23);
            txtRua.TabIndex = 3;
            toolTip.SetToolTip(txtRua, "Insira a rua onde o evento vai acontecer");
            txtRua.Leave += txtRua_Leave;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(581, 67);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(59, 23);
            txtCodPostal.TabIndex = 4;
            txtCodPostal.Text = "0000-000";
            txtCodPostal.TextAlign = HorizontalAlignment.Center;
            toolTip.SetToolTip(txtCodPostal, "Insira o código postal do evento");
            txtCodPostal.Leave += txtCodPostal_Leave;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblRua
            // 
            lblRua.Location = new Point(40, 71);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(48, 15);
            lblRua.TabIndex = 13;
            lblRua.Text = "Rua";
            // 
            // lblCodPostal
            // 
            lblCodPostal.Location = new Point(506, 71);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(69, 15);
            lblCodPostal.TabIndex = 13;
            lblCodPostal.Text = "Cod. Postal";
            // 
            // btnEstatisticas
            // 
            btnEstatisticas.Location = new Point(40, 376);
            btnEstatisticas.Name = "btnEstatisticas";
            btnEstatisticas.Size = new Size(75, 23);
            btnEstatisticas.TabIndex = 14;
            btnEstatisticas.Text = "Estatisticas";
            btnEstatisticas.UseVisualStyleBackColor = true;
            btnEstatisticas.Click += btnEstatisticas_Click;
            // 
            // btnMostrarVips
            // 
            btnMostrarVips.Location = new Point(212, 376);
            btnMostrarVips.Name = "btnMostrarVips";
            btnMostrarVips.Size = new Size(85, 23);
            btnMostrarVips.TabIndex = 15;
            btnMostrarVips.Text = "Ver VIPs";
            btnMostrarVips.UseVisualStyleBackColor = true;
            btnMostrarVips.Click += btnMostrarVips_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(684, 421);
            Controls.Add(btnMostrarVips);
            Controls.Add(btnEstatisticas);
            Controls.Add(txtCodPostal);
            Controls.Add(lblCodPostal);
            Controls.Add(txtRua);
            Controls.Add(lblRua);
            Controls.Add(btnAdicionar);
            Controls.Add(cmbEventos);
            Controls.Add(btnRemoverEvento);
            Controls.Add(btnSobre);
            Controls.Add(btnSair);
            Controls.Add(nudMaxPart);
            Controls.Add(grpPart);
            Controls.Add(dtpData);
            Controls.Add(chkEditar);
            Controls.Add(lblMaxPart);
            Controls.Add(lblData);
            Controls.Add(lblEventos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Gestão de Eventos";
            Load += frmPrincipal_Load;
            grpPart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPart).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEventos;
        private Label lblData;
        private Label lblMaxPart;
        private CheckBox chkEditar;
        private DateTimePicker dtpData;
        private GroupBox grpPart;
        private DataGridView dgvDados;
        private Button btnInscrever;
        private Button btnRemover;
        private NumericUpDown nudMaxPart;
        private Button btnSair;
        private Button btnSobre;
        private Button btnEditar;
        private ListBox listBox1;
        private Button btnRemoverEvento;
        private ToolTip toolTip;
        private ErrorProvider errorProvider;
        private ComboBox cmbEventos;
        private Button btnAdicionar;
        private TextBox txtRua;
        private Label lblRua;
        private TextBox txtCodPostal;
        private Label lblCodPostal;
        private Button btnEstatisticas;
        private Button btnMostrarVips;
    }
}
