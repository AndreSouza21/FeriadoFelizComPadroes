using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class PainelControle : Observador
    {
        public PainelControle() { }
        public void Atualizar(double temperatura)
        {
            Console.WriteLine($"Painel: Temperatura = {temperatura}");
        }
    }
}
