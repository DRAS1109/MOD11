using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventoTecnologia
{
    internal static class Dados
    {
        public static Evento evento;

        // Configurações da app
        public static string appNome = "EventoTecnologia";
        public static string appVer = "vBeta";

        public static string NomeEvento = "Technologia 26";
        public static DateTime DataEvento = new DateTime(2026, 3, 14);
        public static int CapMaxEvento = 200;

        static Dados()
        {
            // Evento de teste
            evento = new Evento(NomeEvento, DataEvento, CapMaxEvento);

            // Alguns participantes de teste
            evento.InscreverParticipante(new Participante("Joaquim", "jocas2009@gmail.com"));
            evento.InscreverParticipante(new Participante("Denis", 17, "denistche@gmail.com"));
        }
    }
}

