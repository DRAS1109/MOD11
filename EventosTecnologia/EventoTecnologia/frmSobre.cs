using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();

            // Exemplo de texto dinâmico
            lblSobre.Text = $"{Dados.appNome}\n" +
                           "Criado por: Dinis Sousa, Nº3, 11º T\n" +
                           $"Versão: {Dados.appVer}\n" +
                           "\n" +
                           "Permite gerir eventos e os respetivos participantes.\n" +
                           "Permite inscrever e remover participantes do evento.\n" +
                           "Permite editar informações sobre o evento.\n" +
                           "Caso o dia do evento já tenha passado, algumas ações\n" +
                           "ficam bloqueadas.\n";
        }

        // Botão Ok (quando clicado volta para o forms principal)
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
