using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class DistanciaService
    {
        public DistanciaService() { }
        public double CalcularDistancia(Posicao origem, Posicao destino)
        {
            return Math.Abs(origem.GetLat() - destino.GetLat()) + Math.Abs(origem.GetLong() - destino.GetLong());
        }
    }
}
