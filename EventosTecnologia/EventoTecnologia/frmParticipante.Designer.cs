namespace EventoTecnologia
{
    partial class frmParticipante
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblIdade = new Label();
            btnOk = new Button();
            btnCancelar = new Button();
            nudIdade = new NumericUpDown();
            lblID = new Label();
            txtID = new TextBox();
            errorProvider = new ErrorProvider(components);
            chkVIP = new CheckBox();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(71, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 0;
            toolTip.SetToolTip(txtNome, "Insira o nome completo do participante");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(71, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 1;
            toolTip.SetToolTip(txtEmail, "Insira um email válido para contato");
            // 
            // lblNome
            // 
            lblNome.Location = new Point(25, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(25, 76);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(380, 26);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 5;
            lblIdade.Text = "Idade";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(390, 118);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "&Ok";
            toolTip.SetToolTip(btnOk, "Confirma os dados do participante e fecha o formulário");
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(290, 118);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "&Cancelar";
            toolTip.SetToolTip(btnCancelar, "Cancela a operação e fecha o formulário sem gravar");
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // nudIdade
            // 
            nudIdade.Location = new Point(422, 23);
            nudIdade.Name = "nudIdade";
            nudIdade.Size = new Size(43, 23);
            nudIdade.TabIndex = 8;
            toolTip.SetToolTip(nudIdade, "Insira a idade do participante (mínimo 16 anos)");
            // 
            // lblID
            // 
            lblID.Location = new Point(25, 121);
            lblID.Name = "lblID";
            lblID.Size = new Size(40, 15);
            lblID.TabIndex = 9;
            lblID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(71, 118);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(43, 23);
            txtID.TabIndex = 10;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // chkVIP
            // 
            chkVIP.AutoSize = true;
            chkVIP.Location = new Point(356, 72);
            chkVIP.Name = "chkVIP";
            chkVIP.Size = new Size(109, 19);
            chkVIP.TabIndex = 11;
            chkVIP.Text = "Participante VIP";
            toolTip.SetToolTip(chkVIP, "Marque se o participante for VIP e deseja adicionar benefícios");
            chkVIP.UseVisualStyleBackColor = true;
            // 
            // frmParticipante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 161);
            Controls.Add(chkVIP);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(nudIdade);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(lblIdade);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmParticipante";
            Text = "Participante";
            Load += frmParticipante_Load;
            ((System.ComponentModel.ISupportInitialize)nudIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblNome;
        private Label lblEmail;
        private Label lblIdade;
        private Button btnOk;
        private Button btnCancelar;
        private NumericUpDown nudIdade;
        private Label lblID;
        private TextBox txtID;
        private ErrorProvider errorProvider;
        private CheckBox chkVIP;
        private ToolTip toolTip;
    }
}