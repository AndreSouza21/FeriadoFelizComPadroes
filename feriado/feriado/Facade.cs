using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Facade
    {
        public double UltimoFrete { get; private set; }
        private Carga carga { get; set; }

        public Pedido pedido { get; private set; }
        
        public Facade() { }

        public void Despachar(string tipoTransportadora, double peso, CalculoFrete frete)
        {
            LogSistema.Instancia.Registrar("Iniciando despacho");

            var transportadora = Factory.Criar(tipoTransportadora);

            UltimoFrete = frete.Calcular(peso);

            Console.WriteLine(transportadora.Entregar());
            Console.WriteLine($"Frete: {UltimoFrete}");

            var sensor = new SensorTemperatura();
            sensor.AdicionarObservador(new PainelControle());
            sensor.AdicionarObservador(new Alerta());

            sensor.SetTemperatura(35);
            sensor.SetTemperatura(12);
            sensor.SetTemperatura(16);

            criaPedido(UltimoFrete);

            LogSistema.Instancia.Registrar("Despacho finalizado");

        }

        public void SetCarga(Carga adicional)
        {
            this.carga = adicional;
            atualizaPedido(carga.Descricao(), carga.Custo());
        }

        public Carga GetCarga()
        {
            return this.carga;
        }

        protected void criaPedido(double frete)
        {
            this.pedido = new Pedido(frete);
        }

        protected void atualizaPedido(string desc,  double valor)
        {
            this.pedido.setCarga(valor,desc);
        }

    }
}
