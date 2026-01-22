namespace Ex02_Medias
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
            txtNum1 = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtNum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblErro = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(75, 40);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(25, 100);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Media";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(225, 100);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 23);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado: ";
            lblResultado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(275, 41);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 3;
            label1.Text = "Num 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(225, 40);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 3;
            label2.Text = "Num 2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErro
            // 
            lblErro.Location = new Point(25, 160);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(350, 23);
            lblErro.TabIndex = 4;
            lblErro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 211);
            Controls.Add(lblErro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum2);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNum1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Calculadora de medias";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Button btnCalcular;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
        private TextBox txtNum2;
        private Label label1;
        private Label label2;
        private Label lblErro;
    }
}
