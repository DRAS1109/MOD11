namespace Ex04_Pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarT_Click(object sender, EventArgs e)
        {
            //Guardar em ficheiro TXT
            try
            {
                Pessoa p = new Pessoa(int.Parse(txtId.Text), txtNome.Text, int.Parse(txtIdade.Text), txtEmail.Text);
            }

            catch (Exception ex)
            {

            }
        }
    }
}
