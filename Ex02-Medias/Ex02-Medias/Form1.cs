namespace Ex02_Medias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LerValores(out double a, out double b)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNum1.Text))
            {
                errorProvider1.SetError(txtNum1, "Campo obrigatório");
                throw new Exception("Precisa preencher o campo número 1");
            }

            if (string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                errorProvider1.SetError(txtNum1, "Campo obrigatório");
                throw new Exception("Precisa preencher o campo número 2");
            }

            if (!double.TryParse(txtNum1.Text, out a))
            {
                errorProvider1.SetError(txtNum1, "Valor inválido");
                throw new Exception("Número 1 não é um valor numérico válido");
            }

            if (!double.TryParse(txtNum2.Text, out b))
            {
                errorProvider1.SetError(txtNum2, "Valor inválido");
                throw new Exception("Número 2 não é um valor numérico válido");
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                LerValores(out double a, out double b);
                lblResultado.Text = "Resultado: " + ((a + b) / 2);
            }

            catch (FormatException ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }

            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}
