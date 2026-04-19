using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class CargaBase : Carga
    {
        public CargaBase() { }
        public string Descricao() => "Carga básica";
        public double Custo() => 100;
    }
}
