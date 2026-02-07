namespace EventoTecnologia
{
    partial class frmEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnCancelar = new Button();
            btnOk = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            nudMaxPart = new NumericUpDown();
            dtpData = new DateTimePicker();
            lblMaxPart = new Label();
            lblData = new Label();
            errorProvider = new ErrorProvider(components);
            txtCodPostal = new TextBox();
            lblCodPostal = new Label();
            txtRua = new TextBox();
            lblRua = new Label();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudMaxPart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(310, 164);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "&Cancelar";
            toolTip.SetToolTip(btnCancelar, "Cancela a operação e fecha o formulário sem gravar");
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(403, 164);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "&Ok";
            toolTip.SetToolTip(btnOk, "Confirma os dados do evento e fecha o formulário");
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(28, 28);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 23);
            txtNome.TabIndex = 0;
            toolTip.SetToolTip(txtNome, "Insira o nome do evento");
            // 
            // nudMaxPart
            // 
            nudMaxPart.BackColor = Color.White;
            nudMaxPart.Location = new Point(418, 111);
            nudMaxPart.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudMaxPart.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudMaxPart.Name = "nudMaxPart";
            nudMaxPart.Size = new Size(60, 23);
            nudMaxPart.TabIndex = 4;
            toolTip.SetToolTip(nudMaxPart, "Defina a capacidade máxima de participantes do evento");
            nudMaxPart.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // dtpData
            // 
            dtpData.CalendarMonthBackground = Color.White;
            dtpData.Location = new Point(78, 111);
            dtpData.MinDate = new DateTime(1809, 9, 11, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(190, 23);
            dtpData.TabIndex = 3;
            toolTip.SetToolTip(dtpData, "Selecione a data do evento");
            dtpData.Value = new DateTime(2026, 2, 5, 0, 0, 0, 0);
            // 
            // lblMaxPart
            // 
            lblMaxPart.AutoSize = true;
            lblMaxPart.Location = new Point(293, 115);
            lblMaxPart.Name = "lblMaxPart";
            lblMaxPart.Size = new Size(118, 15);
            lblMaxPart.TabIndex = 5;
            lblMaxPart.Text = "Nº Max Participantes";
            // 
            // lblData
            // 
            lblData.Location = new Point(28, 115);
            lblData.Name = "lblData";
            lblData.Size = new Size(40, 15);
            lblData.TabIndex = 5;
            lblData.Text = "Data";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(418, 68);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(59, 23);
            txtCodPostal.TabIndex = 2;
            txtCodPostal.Text = "0000-000";
            txtCodPostal.TextAlign = HorizontalAlignment.Center;
            toolTip.SetToolTip(txtCodPostal, "Insira o código postal do local do evento");
            // 
            // lblCodPostal
            // 
            lblCodPostal.Location = new Point(343, 72);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(69, 15);
            lblCodPostal.TabIndex = 16;
            lblCodPostal.Text = "Cod. Postal";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(78, 68);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(245, 23);
            txtRua.TabIndex = 1;
            toolTip.SetToolTip(txtRua, "Insira a rua onde o evento irá ocorrer");
            // 
            // lblRua
            // 
            lblRua.Location = new Point(28, 72);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(44, 15);
            lblRua.TabIndex = 17;
            lblRua.Text = "Rua";
            // 
            // frmEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 206);
            Controls.Add(txtCodPostal);
            Controls.Add(lblCodPostal);
            Controls.Add(txtRua);
            Controls.Add(lblRua);
            Controls.Add(nudMaxPart);
            Controls.Add(dtpData);
            Controls.Add(lblMaxPart);
            Controls.Add(lblData);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmEvento";
            Text = "Adicionar Evento";
            ((System.ComponentModel.ISupportInitialize)nudMaxPart).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnOk;
        private Label lblNome;
        private TextBox txtNome;
        private NumericUpDown nudMaxPart;
        private DateTimePicker dtpData;
        private Label lblMaxPart;
        private Label lblData;
        private ErrorProvider errorProvider;
        private TextBox txtCodPostal;
        private Label lblCodPostal;
        private TextBox txtRua;
        private Label lblRua;
        private ToolTip toolTip;
    }
}