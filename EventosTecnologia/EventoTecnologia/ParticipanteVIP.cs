using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoTecnologia
{
    public class ParticipanteVIP : Participante
    {
        public string Beneficios { get; set; }

        public ParticipanteVIP(string _nome, int _idade, string _email, string _beneficios) : base(_nome, _idade, _email)
        {
            Beneficios = _beneficios;
        }

        public ParticipanteVIP(string _nome, string _email, string _beneficios) : base(_nome, 16, _email)
        {
            Beneficios = _beneficios;
        }

        internal ParticipanteVIP(int _id, string _nome, int _idade, string _email, string _beneficios) : base(_id, _nome, _idade, _email)
        {
            Beneficios = _beneficios;
        }

        internal ParticipanteVIP(int _id, string _nome, string _email, string _beneficios) : base(_id, _nome, 16, _email)
        {
            Beneficios = _beneficios;
        }

        public ParticipanteVIP() : base()
        {
            Beneficios = "Por definir...";
        }

        public override string GetDescricao()
        {
            return base.GetDescricao() + $" | VIP: {Beneficios}";
        }
    }
}
