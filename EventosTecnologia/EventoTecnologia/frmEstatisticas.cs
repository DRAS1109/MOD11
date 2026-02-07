using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class frmEstatisticas : Form
    {
        public frmEstatisticas()
        {
            InitializeComponent();
        }

        private void frmEstatisticas_Load(object sender, EventArgs e)
        {
            if (Dados.EventoAtual == null || Dados.EventoAtual.part.Count == 0)
            {
                lblTotalParticipantes.Text = "Total: 0";
                lblTotalVIP.Text = "VIP: 0";
                lblMediaIdade.Text = "Média Idade: Sem Dados";
                lblIdadeMin.Text = "Idade Mínima: Sem Dados";
                lblIdadeMax.Text = "Idade Máxima: Sem Dados";
                lblPercVIP.Text = "VIP: Sem Dados";
                return;
            }

            int total = Dados.EventoAtual.part.Count;
            int totalVIP = Dados.EventoAtual.part.OfType<ParticipanteVIP>().Count();
            double mediaIdade = Dados.EventoAtual.part.Average(p => p.Idade);

            lblTotalParticipantes.Text = $"Total: {total}";
            lblTotalVIP.Text = $"VIP: {totalVIP}";
            lblMediaIdade.Text = $"Média Idade: {mediaIdade:F1}";

            int idadeMin = Dados.EventoAtual.part.Min(p => p.Idade);
            int idadeMax = Dados.EventoAtual.part.Max(p => p.Idade);
            lblIdadeMin.Text = $"Idade Mínima: {idadeMin}";
            lblIdadeMax.Text = $"Idade Máxima: {idadeMax}";

            double percVIP = ((double)totalVIP / total) * 100;
            lblPercVIP.Text = $"VIP: {percVIP:F1}%";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
