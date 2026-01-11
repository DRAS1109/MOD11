namespace Ex01_Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void ValidarDivisor(double divisor)
        {
            if (divisor == 0)
            {
                errorProvider1.SetError(txtNum2, "O divisor não pode ser zero.");
                throw new DivideByZeroException("Não pode dividir por zero.");
            }
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

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                LerValores(out double a, out double b);
                lblResultado.Text = (a + b).ToString();
            }

            catch (FormatException ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }

            catch (Exception ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                LerValores(out double a, out double b);
                lblResultado.Text = (a - b).ToString();
            }

            catch (FormatException ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }

            catch (Exception ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                LerValores(out double a, out double b);
                ValidarDivisor(b);
                lblResultado.Text = (a / b).ToString();
            }

            catch (FormatException ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }

            catch (DivideByZeroException ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }

            catch (Exception ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                LerValores(out double a, out double b);
                lblResultado.Text = (a * b).ToString();
            }

            catch (FormatException ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }

            catch (Exception ex)
            {
                lblResultado.Text = "Erro " + ex.Message;
            }
        }
    }
}
