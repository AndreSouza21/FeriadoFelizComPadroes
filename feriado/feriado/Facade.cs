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

        public void Despachar(string tipoTransportadora, double peso, CalculoFrete frete, double lat, double lon)
        {
            //log inicial
            LogSistema.Instancia.Registrar("Iniciando despacho");

            //parte da distancia
            Posicao pos = new GPS(lat, lon);
            Posicao ori = new GPSAdapter();

            double distancia = new DistanciaService().CalcularDistancia(ori, pos);                       

            //transporte
            var transportadora = Factory.Criar(tipoTransportadora);

            UltimoFrete = frete.Calcular(peso, distancia);

            Console.WriteLine(transportadora.Entregar());
            Console.WriteLine($"Frete: {UltimoFrete}");

            //observador
            var sensor = SensorTemperatura.Instancia;
            sensor.AdicionarObservador(new PainelControle());
            sensor.AdicionarObservador(new Alerta());

            //exemplificar o observador funcionando
            sensor.SetTemperatura(35);
            sensor.SetTemperatura(12);
            sensor.SetTemperatura(16);

            //finaliza o despache junto log de saida
            criaPedido(UltimoFrete, distancia);
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

        protected void criaPedido(double frete, double distancia)
        {
            this.pedido = new Pedido(frete, distancia);
        }

        protected void atualizaPedido(string desc,  double valor)
        {
            this.pedido.setCarga(valor,desc);
        }

    }
}
