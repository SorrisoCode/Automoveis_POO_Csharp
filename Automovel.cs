using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Automovel
    {
        //visibilidade private, public, protected, internal

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidade { get; set; }
        public int Ano { get; set; }
        public string Imagem { get; set; }

        public Automovel(string marca, string modelo, string velocidade, int ano, string Imagem)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Velocidade = velocidade;
            this.Ano = ano;
            this.Imagem = Imagem;   
        }

        /* antiga
        private string Marca;

        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public string GetMarca()
        {
            return this.Marca;
        }

        public Automovel(string marca)
        {
            this.Marca = marca;
        }
        */
    }
}