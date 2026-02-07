using System.Net.Mail;
using System.Text.Json.Serialization;

namespace EventoTecnologia
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Participante), "participante")]
    [JsonDerivedType(typeof(ParticipanteVIP), "vip")]

    public class Participante
    {
        public bool IdadeValida { get; private set; } = true;
        public bool EmailValido { get; private set; } = true;

        private static int autoID = 0;

        public int ID { get; set; }

        public string Nome { get; set; }

        int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (IsValidIdade(value))
                    idade = value;
                else
                {
                    idade = 0;
                    IdadeValida = false;
                }   
            }
        }

        string email = "";
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value;
                else
                {
                    email = "";
                    EmailValido = false;
                }
            }
        }


         
        public Participante() { }

        public Participante(string _nome, int _idade, string _email)
        {
            ID = ++autoID;
            Nome = _nome;
            Idade = _idade;
            Email = _email;
        }

        public Participante(string _nome, string _email) : this(_nome, 16, _email)
        {

        }

        internal Participante(int _id, string _nome, int _idade, string _email)
        {
            ID = _id;
            Nome = _nome;
            Idade = _idade;
            Email = _email;

            if (_id > autoID)
                autoID = _id;
        }

        internal Participante(int _id, string _nome, string _email) : this(_id, _nome, 16, _email)
        {

        }

        public static void DefinirMaxID(int valor)
        {
            if (valor > autoID)
                autoID = valor;
        }

        public static bool IsValidEmail(string email)
        {
            bool valido = true;

            try
            {
                MailAddress aux = new MailAddress(email);
            }
            catch (Exception)
            {
                valido = false;
            }

            return valido;
        }

        public static bool IsValidIdade(int idade)
        {
            bool valido = true;

            if (idade < 16)
            {
                valido = false;
            }

            return valido;
        }

        public virtual string GetDescricao()
        {
            return $"Nome: {Nome} - Idade: {Idade} - Email: {Email}";
        }
    }
}