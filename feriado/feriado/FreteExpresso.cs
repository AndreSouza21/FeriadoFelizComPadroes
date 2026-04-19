using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class FreteExpresso : CalculoFrete
    {
        public FreteExpresso() { }
        public double Calcular(double peso) => peso * 2 + 50;
    }
}
