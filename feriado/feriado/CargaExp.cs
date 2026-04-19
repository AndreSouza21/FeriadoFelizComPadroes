using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class CargaExp : Carga
    {
        public CargaExp() { }
        public string Descricao() => "\nCarga Expecial";
        public double Custo() => 400;
    }
}
