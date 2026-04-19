using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Rodoviaria : Transportadora
    {
        public Rodoviaria() { }
        public string Entregar() => "Entrega por via rodoviária";
    }
}
