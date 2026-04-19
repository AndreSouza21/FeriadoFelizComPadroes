using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Alerta : Observador
    {
        public Alerta() { }
        public void Atualizar(double temperatura)
        {
            if (temperatura > 30)
                Console.WriteLine("ALERTA DE TEMPERATURA ALTA!");
        }
    }
}
