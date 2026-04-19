using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class SensorTemperatura
    {
        public SensorTemperatura() { }

        private List<Observador> observadores = new List<Observador>();
        private double temperatura;

        public void AdicionarObservador(Observador obs)
        {
            observadores.Add(obs);
        }

        public void SetTemperatura(double temp)
        {
            temperatura = temp;
            Notificar();
        }

        private void Notificar()
        {
            foreach (var obs in observadores)
                obs.Atualizar(temperatura);
        }
    }
}
