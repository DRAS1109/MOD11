namespace Ex01_Calculadora
{
    partial class Calculadora
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
            errorProvider1 = new ErrorProvider(components);
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblResultado = new Label();
            lbltxtResult = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnDividir = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnSomar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(30, 50);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(43, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Num 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(200, 50);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(43, 15);
            lblNum2.TabIndex = 0;
            lblNum2.Text = "Num 2";
            // 
            // lblResultado
            // 
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.Location = new Point(95, 199);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(254, 23);
            lblResultado.TabIndex = 0;
            lblResultado.UseWaitCursor = true;
            // 
            // lbltxtResult
            // 
            lbltxtResult.AutoSize = true;
            lbltxtResult.Location = new Point(30, 200);
            lbltxtResult.Name = "lbltxtResult";
            lbltxtResult.Size = new Size(59, 15);
            lbltxtResult.TabIndex = 0;
            lbltxtResult.Text = "Resultado";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(74, 47);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(249, 47);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(74, 127);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(100, 23);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(249, 87);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(100, 23);
            btnSubtrair.TabIndex = 4;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(249, 127);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(100, 23);
            btnMultiplicar.TabIndex = 5;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(74, 87);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(100, 23);
            btnSomar.TabIndex = 6;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(384, 261);
            Controls.Add(btnSomar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnDividir);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lbltxtResult);
            Controls.Add(lblResultado);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Calculadora";
            Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lbltxtResult;
        private Label lblResultado;
        private Label lblNum2;
        private Label lblNum1;
        private Button btnDividir;
        private Button btnSomar;
        private Button btnMultiplicar;
        private Button btnSubtrair;
    }
}
