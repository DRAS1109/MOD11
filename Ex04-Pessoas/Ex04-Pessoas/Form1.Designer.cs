namespace Ex04_Pessoas
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnLerJ = new Button();
            btnGuardarJ = new Button();
            btnLerT = new Button();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtEmail = new TextBox();
            btnGuardarT = new Button();
            txtId = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblIdade = new Label();
            lblEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(400, 140);
            dataGridView1.TabIndex = 9;
            // 
            // btnLerJ
            // 
            btnLerJ.Location = new Point(342, 159);
            btnLerJ.Name = "btnLerJ";
            btnLerJ.Size = new Size(100, 23);
            btnLerJ.TabIndex = 7;
            btnLerJ.Text = "Ler JSON";
            btnLerJ.UseVisualStyleBackColor = true;
            // 
            // btnGuardarJ
            // 
            btnGuardarJ.Location = new Point(342, 119);
            btnGuardarJ.Name = "btnGuardarJ";
            btnGuardarJ.Size = new Size(100, 23);
            btnGuardarJ.TabIndex = 6;
            btnGuardarJ.Text = "Guardar JSON";
            btnGuardarJ.UseVisualStyleBackColor = true;
            // 
            // btnLerT
            // 
            btnLerT.Location = new Point(342, 79);
            btnLerT.Name = "btnLerT";
            btnLerT.Size = new Size(100, 23);
            btnLerT.TabIndex = 5;
            btnLerT.Text = "Ler TXT";
            btnLerT.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(90, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(90, 120);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(200, 23);
            txtIdade.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(90, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnGuardarT
            // 
            btnGuardarT.Location = new Point(342, 39);
            btnGuardarT.Name = "btnGuardarT";
            btnGuardarT.Size = new Size(100, 23);
            btnGuardarT.TabIndex = 4;
            btnGuardarT.Text = "Guardar TXT";
            btnGuardarT.UseVisualStyleBackColor = true;
            btnGuardarT.Click += btnGuardarT_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(90, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Location = new Point(40, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 23);
            lblId.TabIndex = 9;
            lblId.Text = "Id";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(40, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 23);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIdade
            // 
            lblIdade.Location = new Point(40, 120);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(50, 23);
            lblIdade.TabIndex = 9;
            lblIdade.Text = "Idade";
            lblIdade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(40, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 386);
            Controls.Add(lblEmail);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnGuardarT);
            Controls.Add(txtEmail);
            Controls.Add(txtIdade);
            Controls.Add(dataGridView1);
            Controls.Add(btnLerJ);
            Controls.Add(btnGuardarJ);
            Controls.Add(btnLerT);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Pessoas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLerJ;
        private Button btnGuardarJ;
        private Button btnLerT;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtEmail;
        private Button btnGuardarT;
        private TextBox txtId;
        private Label lblId;
        private Label lblNome;
        private Label lblIdade;
        private Label lblEmail;
    }
}
