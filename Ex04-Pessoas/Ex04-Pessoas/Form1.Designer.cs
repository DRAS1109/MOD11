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
            dgvPessoas = new DataGridView();
            btnLerJ = new Button();
            btnGuardarJ = new Button();
            btnLerT = new Button();
            btnGuardarT = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtEmail = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblIdade = new Label();
            lblEmail = new Label();
            btnM18TXT = new Button();
            btnM18JSON = new Button();
            btnConverterTXT_JSON = new Button();
            btnConverterJSON_TXT = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            SuspendLayout();
            // 
            // dgvPessoas
            // 
            dgvPessoas.AllowUserToAddRows = false;
            dgvPessoas.AllowUserToDeleteRows = false;
            dgvPessoas.AllowUserToOrderColumns = true;
            dgvPessoas.AllowUserToResizeColumns = false;
            dgvPessoas.AllowUserToResizeRows = false;
            dgvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoas.Location = new Point(42, 207);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.Size = new Size(400, 140);
            dgvPessoas.TabIndex = 12;
            // 
            // btnLerJ
            // 
            btnLerJ.Location = new Point(342, 159);
            btnLerJ.Name = "btnLerJ";
            btnLerJ.Size = new Size(100, 23);
            btnLerJ.TabIndex = 7;
            btnLerJ.Text = "Ler JSON";
            btnLerJ.UseVisualStyleBackColor = true;
            btnLerJ.Click += btnLerJ_Click;
            // 
            // btnGuardarJ
            // 
            btnGuardarJ.Location = new Point(342, 119);
            btnGuardarJ.Name = "btnGuardarJ";
            btnGuardarJ.Size = new Size(100, 23);
            btnGuardarJ.TabIndex = 6;
            btnGuardarJ.Text = "Guardar JSON";
            btnGuardarJ.UseVisualStyleBackColor = true;
            btnGuardarJ.Click += btnGuardarJ_Click;
            // 
            // btnLerT
            // 
            btnLerT.Location = new Point(342, 79);
            btnLerT.Name = "btnLerT";
            btnLerT.Size = new Size(100, 23);
            btnLerT.TabIndex = 5;
            btnLerT.Text = "Ler TXT";
            btnLerT.UseVisualStyleBackColor = true;
            btnLerT.Click += btnLerT_Click;
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
            // lblId
            // 
            lblId.Location = new Point(40, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 23);
            lblId.TabIndex = 12;
            lblId.Text = "Id";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(40, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 23);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIdade
            // 
            lblIdade.Location = new Point(40, 120);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(50, 23);
            lblIdade.TabIndex = 12;
            lblIdade.Text = "Idade";
            lblIdade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(40, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 23);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnM18TXT
            // 
            btnM18TXT.Location = new Point(42, 365);
            btnM18TXT.Name = "btnM18TXT";
            btnM18TXT.Size = new Size(190, 23);
            btnM18TXT.TabIndex = 8;
            btnM18TXT.Text = "Maiores de 18 TXT";
            btnM18TXT.UseVisualStyleBackColor = true;
            btnM18TXT.Click += btnM18TXT_Click;
            // 
            // btnM18JSON
            // 
            btnM18JSON.Location = new Point(252, 365);
            btnM18JSON.Name = "btnM18JSON";
            btnM18JSON.Size = new Size(190, 23);
            btnM18JSON.TabIndex = 9;
            btnM18JSON.Text = "Maiores de 18 JSON";
            btnM18JSON.UseVisualStyleBackColor = true;
            btnM18JSON.Click += btnM18JSON_Click;
            // 
            // btnConverterTXT_JSON
            // 
            btnConverterTXT_JSON.Location = new Point(42, 400);
            btnConverterTXT_JSON.Name = "btnConverterTXT_JSON";
            btnConverterTXT_JSON.Size = new Size(190, 23);
            btnConverterTXT_JSON.TabIndex = 11;
            btnConverterTXT_JSON.Text = "Converter TXT -> JSON";
            btnConverterTXT_JSON.UseVisualStyleBackColor = true;
            btnConverterTXT_JSON.Click += btnConverterTXT_JSON_Click;
            // 
            // btnConverterJSON_TXT
            // 
            btnConverterJSON_TXT.Location = new Point(252, 400);
            btnConverterJSON_TXT.Name = "btnConverterJSON_TXT";
            btnConverterJSON_TXT.Size = new Size(190, 23);
            btnConverterJSON_TXT.TabIndex = 10;
            btnConverterJSON_TXT.Text = "Converter JSON -> TXT";
            btnConverterJSON_TXT.UseVisualStyleBackColor = true;
            btnConverterJSON_TXT.Click += btnConverterJSON_TXT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 441);
            Controls.Add(btnM18JSON);
            Controls.Add(btnConverterJSON_TXT);
            Controls.Add(btnConverterTXT_JSON);
            Controls.Add(btnM18TXT);
            Controls.Add(lblEmail);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnGuardarT);
            Controls.Add(txtEmail);
            Controls.Add(txtIdade);
            Controls.Add(dgvPessoas);
            Controls.Add(btnLerJ);
            Controls.Add(btnGuardarJ);
            Controls.Add(btnLerT);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Pessoas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPessoas;
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
        private Button btnM18TXT;
        private Button btnConverterTXT_JSON;
        private Button btnConverterJSON_TXT;
        private Button btnM18JSON;
    }
}
