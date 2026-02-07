using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventoTecnologia
{
    public class Localizacao
    {
        /// <summary>
        /// Criar constante para código postal por defeito
        /// </summary>

        public const string DefaultCodPostal = "0000-000";

        /// <summary>
        /// Rua do Evento
        /// </summary>
        public string Rua { get; set; }

        /// <summary>
        /// Codigo Postal do Evento
        /// </summary>
        private string codPostal { get; set; }

        /// <summary>
        /// Código Postal com o formato 0000-000
        /// </summary>
        public string CodPostal
        {
            get
            {
                return codPostal;
            }

            set
            {
                if (IsValidCodPostal(value))
                    codPostal = value;

                else
                    codPostal = DefaultCodPostal;
            }
        }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="rua">Rua</param>
        /// <param name="codPostal">Codigo Postal</param>

        public Localizacao(string rua, string codPostal)
        {
            Rua = rua;
            CodPostal = codPostal;
        }

        /// <summary>
        /// Construtor com os pârametros essenciais na criação do objeto
        /// </summary>
        /// <param name="codPostal">Código Postal</param>
        public Localizacao(string codPostal) : this("", codPostal)
        {

        }

        /// <summary>
        /// Construtor com parametros por omissões
        /// </summary>
        public Localizacao() : this("", "0000-000")
        {

        }

        /// <summary>
        /// Valida se o código postal está no formato "0000-000"
        /// O metodo é estatico porque a função não depende das caracteristicas do objeto.
        /// </summary>
        /// <param name="_codPostal"></param>
        /// <returns>Devolve true se o codigo postal é válido, caso contrario devolve false</returns>
        public static bool IsValidCodPostal(string _codPostal)
        {
            string pattern = @"^\d{4}-\d{3}$";
            return Regex.IsMatch(_codPostal, pattern);
        }
    }
}
