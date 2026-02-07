namespace EventoTecnologia
{
    partial class frmEstatisticas
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
            grpEstatisticas = new GroupBox();
            lblPercVIP = new Label();
            lblIdadeMax = new Label();
            lblIdadeMin = new Label();
            lblMediaIdade = new Label();
            lblTotalVIP = new Label();
            lblTotalParticipantes = new Label();
            btnSair = new Button();
            grpEstatisticas.SuspendLayout();
            SuspendLayout();
            // 
            // grpEstatisticas
            // 
            grpEstatisticas.Controls.Add(lblPercVIP);
            grpEstatisticas.Controls.Add(lblIdadeMax);
            grpEstatisticas.Controls.Add(lblIdadeMin);
            grpEstatisticas.Controls.Add(lblMediaIdade);
            grpEstatisticas.Controls.Add(lblTotalVIP);
            grpEstatisticas.Controls.Add(lblTotalParticipantes);
            grpEstatisticas.Location = new Point(25, 25);
            grpEstatisticas.Name = "grpEstatisticas";
            grpEstatisticas.Size = new Size(250, 224);
            grpEstatisticas.TabIndex = 1;
            grpEstatisticas.TabStop = false;
            grpEstatisticas.Text = "Estatisticas";
            // 
            // lblPercVIP
            // 
            lblPercVIP.AutoSize = true;
            lblPercVIP.Location = new Point(25, 200);
            lblPercVIP.Name = "lblPercVIP";
            lblPercVIP.Size = new Size(119, 15);
            lblPercVIP.TabIndex = 6;
            lblPercVIP.Text = "Percentagem de VIP: ";
            // 
            // lblIdadeMax
            // 
            lblIdadeMax.AutoSize = true;
            lblIdadeMax.Location = new Point(25, 165);
            lblIdadeMax.Name = "lblIdadeMax";
            lblIdadeMax.Size = new Size(88, 15);
            lblIdadeMax.TabIndex = 5;
            lblIdadeMax.Text = "Idade maxima: ";
            // 
            // lblIdadeMin
            // 
            lblIdadeMin.AutoSize = true;
            lblIdadeMin.Location = new Point(25, 130);
            lblIdadeMin.Name = "lblIdadeMin";
            lblIdadeMin.Size = new Size(86, 15);
            lblIdadeMin.TabIndex = 4;
            lblIdadeMin.Text = "Idade minima: ";
            // 
            // lblMediaIdade
            // 
            lblMediaIdade.AutoSize = true;
            lblMediaIdade.Location = new Point(25, 95);
            lblMediaIdade.Name = "lblMediaIdade";
            lblMediaIdade.Size = new Size(94, 15);
            lblMediaIdade.TabIndex = 3;
            lblMediaIdade.Text = "Média de idade: ";
            // 
            // lblTotalVIP
            // 
            lblTotalVIP.AutoSize = true;
            lblTotalVIP.Location = new Point(25, 60);
            lblTotalVIP.Name = "lblTotalVIP";
            lblTotalVIP.Size = new Size(58, 15);
            lblTotalVIP.TabIndex = 2;
            lblTotalVIP.Text = "Total VIP: ";
            // 
            // lblTotalParticipantes
            // 
            lblTotalParticipantes.AutoSize = true;
            lblTotalParticipantes.Location = new Point(25, 25);
            lblTotalParticipantes.Name = "lblTotalParticipantes";
            lblTotalParticipantes.Size = new Size(125, 15);
            lblTotalParticipantes.TabIndex = 1;
            lblTotalParticipantes.Text = "Total de participantes: ";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(190, 255);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(85, 23);
            btnSair.TabIndex = 13;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmEstatisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 291);
            Controls.Add(btnSair);
            Controls.Add(grpEstatisticas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmEstatisticas";
            Text = "Estatisticas";
            Load += frmEstatisticas_Load;
            grpEstatisticas.ResumeLayout(false);
            grpEstatisticas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEstatisticas;
        private Label lblPercVIP;
        private Label lblIdadeMax;
        private Label lblIdadeMin;
        private Label lblMediaIdade;
        private Label lblTotalVIP;
        private Label lblTotalParticipantes;
        private Button btnSair;
    }
}