using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class FretePadrao : CalculoFrete
    {
        public FretePadrao() { }
        public double Calcular(double peso) => peso * 1.35;
    }
}
