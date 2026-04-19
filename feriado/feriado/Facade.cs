using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Facade
    {
        public Facade() { }
        public void Despachar(string tipoTransportadora, double peso, CalculoFrete frete)
        {
            LogSistema.Instancia.Registrar("Iniciando despacho");

            var transportadora = Factory.Criar(tipoTransportadora);

            double custo = frete.Calcular(peso);

            Console.WriteLine(transportadora.Entregar());
            Console.WriteLine($"Frete: {custo}");

            var sensor = new SensorTemperatura();
            sensor.AdicionarObservador(new PainelControle());
            sensor.AdicionarObservador(new Alerta());

            sensor.SetTemperatura(35);
            sensor.SetTemperatura(12);
            sensor.SetTemperatura(16);

            LogSistema.Instancia.Registrar("Despacho finalizado");
        }
    }
}
