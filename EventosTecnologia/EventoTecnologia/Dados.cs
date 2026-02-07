using EventoTecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;


namespace EventoTecnologia
{
    internal static class Dados
    {
        public static BindingList<Evento> Eventos { get; set; }
        public static Evento EventoAtual { get; set; }

        // Configurações da app
        public static string appNome = "EventoTecnologia";
        public static string appVer = "vBeta";
        static bool fazeTestes = false;

        //Nome ficheiro onde os dados são guardados
        static string Ficheiro = "dados.json";


        static Dados()
        {
            Eventos = new BindingList<Evento>();

            if (fazeTestes)
            {
                Evento eventoTeste = new Evento("Technologia 26", new DateTime(2026, 3, 14), 200, new Localizacao("Rua Terciária", "3270-328"));
                eventoTeste.InscreverParticipante(new Participante("Joaquim", "jocas2009@gmail.com"));
                eventoTeste.InscreverParticipante(new Participante("Denis", 17, "denistche@gmail.com"));

                Evento eventoTeste2 = new Evento("Manual 26", new DateTime(2026, 6, 10), 100, new Localizacao("Rua do Grito", "5816-521"));

                Eventos.Add(eventoTeste);
                Eventos.Add(eventoTeste2);

                EventoAtual = eventoTeste;
            }

        }
        public static void Guardar()
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true,
                    TypeInfoResolver = new DefaultJsonTypeInfoResolver
                    {
                        Modifiers = {}
                    }
                };

                //Guardar lista atualizada
                using (FileStream fs = new FileStream(Ficheiro, FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, Eventos, options);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar ficheiro: " + ex.Message, appNome, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Ler()
        {
            //Ler ficheiro JSON
            try
            {
                using (FileStream fs = new FileStream(Ficheiro, FileMode.Open))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        IncludeFields = true,
                    };

                    List<Evento> listaEventos = JsonSerializer.Deserialize<List<Evento>>(fs, options);

                    int maxID = 0;

                    foreach (Evento e in listaEventos)
                    {
                        EventoAtual = new Evento(e.Nome, e.Data, e.CapacidadeMax, e.Local);
                        Eventos.Add(EventoAtual);

                        foreach(Participante p in e.part)
                        {
                            if (p.ID > maxID)
                                maxID = p.ID;

                            EventoAtual.part.Add(p);
                        }
                    }
                    Participante.DefinirMaxID(maxID);
                }
            }

            catch (Exception ex)
            {

            }
        }
    }
}

