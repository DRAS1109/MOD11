using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    public class Evento
    {
        public BindingList<Participante> part { get; private set; }

        public const int CAPACIDADE_MIN = 1;
        public string Nome { get; set; }
        public DateTime Data { get; set; }


        int capacidadeMax;
        public int CapacidadeMax
        {
            get { return capacidadeMax; }
            set
            {
                if (IsValidCapacidadeMax(value))
                    capacidadeMax = value;
                else
                    capacidadeMax = CAPACIDADE_MIN;
            }
        }


        public Evento(string _nome, DateTime _data, int _capacidadeMax)
        {
            Nome = _nome;
            Data = _data;
            CapacidadeMax = _capacidadeMax;

            part = new BindingList<Participante>();
        }

        public static bool IsValidCapacidadeMax(int capacidade)
        {
            bool valido = true;

            if (capacidade < 1)
            {
                valido = false;
            }

            return valido;
        }

        public bool InscreverParticipante(Participante p)
        {
            if (p == null)
                return false;

            for (int i = 0; i < part.Count; i++)
            {
                if (part[i].Email == p.Email)
                    return false;
            }

            if (part.Count >= CapacidadeMax)
                return false;

            part.Add(p);
            return true;
        }
    }
}

