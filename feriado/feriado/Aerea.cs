using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Aerea : Transportadora
    {
        public Aerea() { } 
        public string Entregar() => "Entrega por via aérea";
    }
}
