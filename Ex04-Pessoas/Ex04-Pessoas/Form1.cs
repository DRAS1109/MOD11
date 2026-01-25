using System;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Ex04_Pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aplica a seleção para toda a linha
            dgvPessoas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Desativar seleção multipla de linhas
            dgvPessoas.MultiSelect = false;

            // Esconder o cabeçalho da linha
            dgvPessoas.RowHeadersVisible = false;

            // Aplicar a DataGridView apenas para leitura
            dgvPessoas.ReadOnly = true;

            // Não tem permissão para adicionar uma nova linha
            dgvPessoas.AllowUserToAddRows = false;

            // Não tem permissão para remover uma linha
            dgvPessoas.AllowUserToDeleteRows = false;

            // Não permite redimensionar a altura das linhas
            dgvPessoas.AllowUserToResizeRows = false;

            // Não permite redimensionar a largura das colunas
            dgvPessoas.AllowUserToResizeColumns = false;

            dgvPessoas.Columns.Clear();

            DataGridViewTextBoxColumn ColId = new DataGridViewTextBoxColumn();
            ColId.Name = "Id";
            ColId.Width = 30;
            dgvPessoas.Columns.Add(ColId);

            DataGridViewTextBoxColumn ColNome = new DataGridViewTextBoxColumn();
            ColNome.Name = "Nome";
            ColNome.Width = 100;
            dgvPessoas.Columns.Add(ColNome);

            DataGridViewTextBoxColumn ColIdade = new DataGridViewTextBoxColumn();
            ColIdade.Name = "Idade";
            ColIdade.Width = 60;
            dgvPessoas.Columns.Add(ColIdade);

            DataGridViewTextBoxColumn ColEmail = new DataGridViewTextBoxColumn();
            ColEmail.Name = "Email";
            ColEmail.Width = 207;
            dgvPessoas.Columns.Add(ColEmail);

            CarregarJson();
        }

        private void btnGuardarT_Click(object sender, EventArgs e)
        {
            //Guardar em ficheiro TXT
            try
            {
                Pessoa p = new Pessoa(int.Parse(txtId.Text), txtNome.Text, int.Parse(txtIdade.Text), txtEmail.Text);

                using (StreamWriter sw = new StreamWriter("Pessoas.txt", true))
                {
                    sw.WriteLine(p.ToString());
                }

                MessageBox.Show("Pessoa guardada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar: " + ex.Message);
            }
        }

        private void btnLerT_Click(object sender, EventArgs e)
        {
            dgvPessoas.Rows.Clear();

            //Ler ficheiro TXT
            if (!File.Exists("Pessoas.txt"))
            {
                MessageBox.Show("O ficheiro Pessoas.txt não existe!");
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader("Pessoas.txt"))
                {
                    string linha;

                    //Ler linha a linha
                    while ((linha = sr.ReadLine()) != null)
                    {
                        //Separar campos
                        string[] dados = linha.Split(" | ");
                        dgvPessoas.Rows.Add(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), dados[3]);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler ficheiro TXT: " + ex.Message);
            }
        }

        private void btnGuardarJ_Click(object sender, EventArgs e)
        {
            //Guardar em ficheiro JSON
            try
            {
                Pessoa p = new Pessoa(int.Parse(txtId.Text), txtNome.Text, int.Parse(txtIdade.Text), txtEmail.Text);

                List<Pessoa> listaPessoas = new List<Pessoa>();

                //Se o ficheiro já existe, ler dados anteriores
                if (File.Exists("Pessoas.json"))
                {
                    using (FileStream fs = new FileStream("Pessoas.json", FileMode.Open))
                    {
                        listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(fs);
                    }
                }
                listaPessoas.Add(p);

                //Guardar lista atualizada
                using (FileStream fs = new FileStream("Pessoas.json", FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, listaPessoas, new JsonSerializerOptions
                    { WriteIndented = true });
                }

                MessageBox.Show("Pessoa guardada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar ficheiro: " + ex.Message);
            }
        }

        private void btnLerJ_Click(object sender, EventArgs e)
        {
            dgvPessoas.Rows.Clear();

            //Ler ficheiro JSON
            try
            {
                if (!File.Exists("Pessoas.json"))
                {
                    MessageBox.Show("Nenhum ficheiro JSON encontrado.");
                    return;
                }

                using (FileStream fs = new FileStream("Pessoas.json", FileMode.Open))
                {
                    List<Pessoa> listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(fs);

                    foreach (Pessoa p in listaPessoas)
                    {
                        dgvPessoas.Rows.Add(p.Id, p.Nome, p.Idade, p.Email);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler ficheiro JSON: " + ex.Message);
            }
        }

        private void btnM18TXT_Click(object sender, EventArgs e)
        {
            dgvPessoas.Rows.Clear();

            using (StreamReader sr = new StreamReader("Pessoas.txt"))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(" | ");
                    int idade = int.Parse(dados[2]);

                    if (idade >= 18)
                    {
                        dgvPessoas.Rows.Add(int.Parse(dados[0]), dados[1], idade, dados[3]);
                    }
                }
            }
        }

        private void btnM18JSON_Click(object sender, EventArgs e)
        {
            dgvPessoas.Rows.Clear();

            using (FileStream fs = new FileStream("Pessoas.json", FileMode.Open))
            {
                List<Pessoa> listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(fs);

                foreach (Pessoa p in listaPessoas)
                {
                    if (p.Idade >= 18)
                    {
                        dgvPessoas.Rows.Add(p.Id, p.Nome, p.Idade, p.Email);
                    }
                }
            }
        }

        private void btnConverterTXT_JSON_Click(object sender, EventArgs e)
        {
            dgvPessoas.Rows.Clear();

            try
            {
                if (!File.Exists("Pessoas.txt"))
                {
                    MessageBox.Show("Nenhum ficheiro TXT encontrado.");
                    return;
                }

                List<Pessoa> listaPessoas = new List<Pessoa>();

                using (StreamReader sr = new StreamReader("Pessoas.txt"))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(" | ");

                        Pessoa p = new Pessoa(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), dados[3]);
                        listaPessoas.Add(p);
                        dgvPessoas.Rows.Add(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), dados[3]);
                    }

                    using (FileStream fs = new FileStream("Pessoas.json", FileMode.Create))
                    {
                        JsonSerializer.Serialize(fs, listaPessoas, new JsonSerializerOptions { WriteIndented = true });
                    }

                    MessageBox.Show("Ficheiro TXT convertido para JSON com sucesso!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro na conversão: " + ex.Message);
            }
        }

        private void btnConverterJSON_TXT_Click(object sender, EventArgs e)
        {
            dgvPessoas.Rows.Clear();

            try
            {
                if (!File.Exists("Pessoas.json"))
                {
                    MessageBox.Show("Nenhum ficheiro JSON encontrado.");
                    return;
                }

                List<Pessoa> listaPessoas = new List<Pessoa>();

                using (FileStream fs = new FileStream("Pessoas.json", FileMode.Open))
                {
                    listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(fs);
                }

                using (StreamWriter sw = new StreamWriter("Pessoas.txt", false))
                {
                    foreach (Pessoa p in listaPessoas)
                    {
                        sw.WriteLine(p.ToString());

                        dgvPessoas.Rows.Add(p.Id, p.Nome, p.Idade, p.Email);
                    }
                }

                MessageBox.Show("Ficheiro JSON convertido para TXT com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conversão: " + ex.Message);
            }

        }

        private void CarregarJson()
        {
            dgvPessoas.Rows.Clear();

            if (!File.Exists("Pessoas.json"))
                return;

            try
            {
                using (FileStream fs = new FileStream("Pessoas.json", FileMode.Open))
                {
                    List<Pessoa> listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(fs);

                    foreach (Pessoa p in listaPessoas)
                    {
                        dgvPessoas.Rows.Add(p.Id, p.Nome, p.Idade, p.Email);
                    }
                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao carregar JSON: " + ex.Message);
            }
        }
    }
}