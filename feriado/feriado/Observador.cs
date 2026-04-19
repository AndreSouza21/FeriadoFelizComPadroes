using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal interface Observador
    {
        void Atualizar(double temperatura);
    }
}
