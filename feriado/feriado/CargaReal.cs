using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class CargaReal : AcessoCarga
    {

        public CargaReal() { }
        

        public void MostrarCustos()
        {
            Console.WriteLine("Custos detalhados da carga...");
        }
    }
}
