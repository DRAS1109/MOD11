using System.Windows.Forms;

namespace Ex03_Carro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            try
            {

                if (string.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    errorProvider1.SetError(txtModelo, "Preencha o campo: modelo.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAno.Text))
                {
                    errorProvider1.SetError(txtAno, "Preencha o campo: ano.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPreco.Text))
                {
                    errorProvider1.SetError(txtPreco, "Preencha o campo: preço.");
                    return;
                }

                int ano = int.Parse(txtAno.Text);
                decimal preco = decimal.Parse(txtPreco.Text);


                if (ano < 0 || ano > DateTime.Now.Year)
                {
                    errorProvider1.SetError(txtAno, "Ano inválido.");
                    return;
                }

                if (preco <= 0)
                {
                    errorProvider1.SetError(txtPreco, "O preço deve ser maior que zero.");
                    return;
                }

                // Criar objeto Carro
                Carro carro = new Carro(txtModelo.Text, ano, preco);


                MessageBox.Show($"Modelo: {carro.Modelo}\nAno: {carro.Ano}\nPreço: {carro.Preco}€",
                    "Informações do Carro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Verifique se o ano e o preço são números inteiros e positivos.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro inesperado: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
