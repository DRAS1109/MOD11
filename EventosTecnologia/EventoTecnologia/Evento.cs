using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    /* INotifyPropertyChanged retirado de https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-10.0
     * da classe public class DemoCustomer : INotifyPropertyChanged */
    public class Evento : INotifyPropertyChanged // Serve para notificar quando uma propriedade de um objeto muda
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public BindingList<Participante> part { get; set; }

        public const int CAPACIDADE_MIN = 2;
        public DateTime Data { get; set; }

        string nome;
        public string Nome 
        { 
            get { return nome; }
            set
            {
                nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }


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

        public Localizacao Local { get; set; }

        public Evento() 
        {
            Local = new Localizacao();
            part = new BindingList<Participante>();
        }

        public Evento(string _nome, DateTime _data, int _capacidadeMax, Localizacao _localizacaoAtual)
        {
            Nome = _nome;
            Data = _data;
            CapacidadeMax = _capacidadeMax;
            Local = _localizacaoAtual;

            part = new BindingList<Participante>();
        }

        public static bool IsValidCapacidadeMax(int capacidade)
        {
            bool valido = true;

            if (capacidade < 2)
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

