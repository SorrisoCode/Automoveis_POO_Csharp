using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carro : Automovel
    {
        public Carro(string marca, string tipo)
            : base(marca, tipo, "0 km/h", 0, "")
        {

        }

        public override string Frear()
        {
            return "Freando o carro com ABS";
        }
    }
}

