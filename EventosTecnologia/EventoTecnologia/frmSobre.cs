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
                            "Funcionalidades principais:\n" +
                            "- Criar, editar e remover eventos.\n" +
                            "- Inscrever, editar e remover participantes.\n" +
                            "- Possibilidade de inscrição de participantes VIP com benefícios.\n" +
                            "- Capacidade máxima por evento com validação.\n" +
                            "- Estatísticas: total participantes, VIPs, média de idade.\n" +
                            "- Ordenação de participantes e destaque visual para VIPs.\n" +
                            "- Validação e gravação de dados.\n" +
                            "\n" +
                            "Nota: Algumas ações ficam bloqueadas se a data do evento já tiver passado.";

        }

        // Botão Ok (quando clicado volta para o forms principal)
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
