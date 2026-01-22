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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblIdade = new Label();
            btnOk = new Button();
            btnCancelar = new Button();
            nudIdade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudIdade).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(262, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(374, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(28, 28);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "&Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 78);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "&Email";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(368, 28);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 5;
            lblIdade.Text = "&Idade";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(378, 118);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "&Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(278, 118);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // nudIdade
            // 
            nudIdade.Location = new Point(410, 25);
            nudIdade.Name = "nudIdade";
            nudIdade.Size = new Size(43, 23);
            nudIdade.TabIndex = 8;
            // 
            // frmParticipante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 161);
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
            Text = "frmParticipante";
            ((System.ComponentModel.ISupportInitialize)nudIdade).EndInit();
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
    }
}