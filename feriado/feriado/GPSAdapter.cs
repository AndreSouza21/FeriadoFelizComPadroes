using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class GPSAdapter : Posicao
    {
        public GPSAdapter() { }

        private SistemaLegadoGPS legado = new SistemaLegadoGPS();

        public double GetLat()
        {
            var dados = legado.GetCoordenadas();
            return double.Parse(dados.Split(';')[0].Split(':')[1]);
        }

        public double GetLong()
        {
            var dados = legado.GetCoordenadas();
            return double.Parse(dados.Split(';')[1].Split(':')[1]);
        }
    }
}
