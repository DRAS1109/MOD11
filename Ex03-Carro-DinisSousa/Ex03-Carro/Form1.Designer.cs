namespace Ex03_Carro
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
            components = new System.ComponentModel.Container();
            txtModelo = new TextBox();
            txtAno = new TextBox();
            txtPreco = new TextBox();
            lbModelo = new Label();
            lblAno = new Label();
            lblPreco = new Label();
            btnMostrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(96, 40);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 1;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(96, 89);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(96, 140);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 2;
            // 
            // lbModelo
            // 
            lbModelo.Location = new Point(40, 40);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(50, 23);
            lbModelo.TabIndex = 4;
            lbModelo.Text = "Modelo";
            lbModelo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAno
            // 
            lblAno.Location = new Point(40, 89);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(50, 23);
            lblAno.TabIndex = 4;
            lblAno.Text = "Ano";
            lblAno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreco
            // 
            lblPreco.Location = new Point(40, 139);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(50, 23);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preco";
            lblPreco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(40, 189);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(156, 23);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 241);
            Controls.Add(btnMostrar);
            Controls.Add(lblPreco);
            Controls.Add(lblAno);
            Controls.Add(lbModelo);
            Controls.Add(txtPreco);
            Controls.Add(txtAno);
            Controls.Add(txtModelo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Carro";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModelo;
        private TextBox txtAno;
        private TextBox txtPreco;
        private Label lbModelo;
        private Label lblAno;
        private Label lblPreco;
        private Button btnMostrar;
        private ErrorProvider errorProvider1;
    }
}
