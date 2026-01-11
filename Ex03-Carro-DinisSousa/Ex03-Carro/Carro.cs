using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Carro
{
    internal class Carro
    {
        public string Modelo {  get; set; }
        public int Ano {  get; set; }
        public decimal Preco {  get; set; }

        public Carro(string modelo, int ano, decimal preco) 
        {
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
        }
    }
}
