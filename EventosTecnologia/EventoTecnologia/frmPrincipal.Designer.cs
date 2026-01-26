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
            lblNome = new Label();
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
            txtNome = new TextBox();
            btnSair = new Button();
            btnSobre = new Button();
            lblPartAtual = new Label();
            txtNPart = new TextBox();
            btnRemoverEvento = new Button();
            grpPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPart).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(45, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(45, 60);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // lblMaxPart
            // 
            lblMaxPart.AutoSize = true;
            lblMaxPart.Location = new Point(304, 60);
            lblMaxPart.Name = "lblMaxPart";
            lblMaxPart.Size = new Size(155, 15);
            lblMaxPart.TabIndex = 2;
            lblMaxPart.Text = "Nº Máximo de Participantes";
            // 
            // chkEditar
            // 
            chkEditar.AutoSize = true;
            chkEditar.Location = new Point(540, 73);
            chkEditar.Name = "chkEditar";
            chkEditar.Size = new Size(95, 19);
            chkEditar.TabIndex = 4;
            chkEditar.Text = "Editar Evento";
            chkEditar.UseVisualStyleBackColor = true;
            chkEditar.CheckedChanged += chkEditar_CheckedChanged;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(90, 56);
            dtpData.MinDate = new DateTime(1809, 9, 11, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(179, 23);
            dtpData.TabIndex = 1;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // grpPart
            // 
            grpPart.Controls.Add(btnEditar);
            grpPart.Controls.Add(btnInscrever);
            grpPart.Controls.Add(btnRemover);
            grpPart.Controls.Add(dgvDados);
            grpPart.Location = new Point(45, 100);
            grpPart.Name = "grpPart";
            grpPart.Size = new Size(590, 203);
            grpPart.TabIndex = 6;
            grpPart.TabStop = false;
            grpPart.Text = "Participantes";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(475, 134);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 46);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar Participante";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInscrever
            // 
            btnInscrever.Location = new Point(475, 30);
            btnInscrever.Name = "btnInscrever";
            btnInscrever.Size = new Size(100, 46);
            btnInscrever.TabIndex = 5;
            btnInscrever.Text = "&Increver Participante";
            btnInscrever.UseVisualStyleBackColor = true;
            btnInscrever.Click += btnInscrever_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(475, 82);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 46);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "&Remover Participante";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(30, 30);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(439, 150);
            dgvDados.TabIndex = 6;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // nudMaxPart
            // 
            nudMaxPart.Location = new Point(474, 56);
            nudMaxPart.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudMaxPart.Name = "nudMaxPart";
            nudMaxPart.Size = new Size(40, 23);
            nudMaxPart.TabIndex = 3;
            nudMaxPart.ValueChanged += nudMaxPart_ValueChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(90, 17);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(424, 23);
            txtNome.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(560, 322);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 9;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnSobre
            // 
            btnSobre.Location = new Point(464, 322);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(75, 23);
            btnSobre.TabIndex = 8;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = true;
            btnSobre.Click += btnSobre_Click;
            // 
            // lblPartAtual
            // 
            lblPartAtual.AutoSize = true;
            lblPartAtual.Location = new Point(45, 326);
            lblPartAtual.Name = "lblPartAtual";
            lblPartAtual.Size = new Size(114, 15);
            lblPartAtual.TabIndex = 11;
            lblPartAtual.Text = "Nº  de Participantes:";
            // 
            // txtNPart
            // 
            txtNPart.Location = new Point(165, 323);
            txtNPart.Name = "txtNPart";
            txtNPart.ReadOnly = true;
            txtNPart.Size = new Size(37, 23);
            txtNPart.TabIndex = 12;
            // 
            // btnRemoverEvento
            // 
            btnRemoverEvento.Font = new Font("Segoe UI", 9F);
            btnRemoverEvento.Location = new Point(535, 17);
            btnRemoverEvento.Name = "btnRemoverEvento";
            btnRemoverEvento.Size = new Size(100, 50);
            btnRemoverEvento.TabIndex = 14;
            btnRemoverEvento.Text = "Remover Evento";
            btnRemoverEvento.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(btnRemoverEvento);
            Controls.Add(txtNPart);
            Controls.Add(lblPartAtual);
            Controls.Add(btnSobre);
            Controls.Add(btnSair);
            Controls.Add(txtNome);
            Controls.Add(nudMaxPart);
            Controls.Add(grpPart);
            Controls.Add(dtpData);
            Controls.Add(chkEditar);
            Controls.Add(lblMaxPart);
            Controls.Add(lblData);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Gestão de Inscrições para Eventos de Tecnologia";
            Load += frmPrincipal_Load;
            grpPart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblData;
        private Label lblMaxPart;
        private CheckBox chkEditar;
        private DateTimePicker dtpData;
        private GroupBox grpPart;
        private DataGridView dgvDados;
        private Button btnInscrever;
        private Button btnRemover;
        private NumericUpDown nudMaxPart;
        private TextBox txtNome;
        private Button btnSair;
        private Button btnSobre;
        private Label lblPartAtual;
        private TextBox txtNPart;
        private Button btnEditar;
        private Button button1;
        private ListBox listBox1;
        private Button btnRemoverEvento;
    }
}
