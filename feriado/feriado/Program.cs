using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade();
            facade.Despachar("aerea", 100, new FreteExpresso(), 50, 60);

            facade.SetCarga(new SeguroCarga(
                                new RastreamentoSatelital(
                                    new CargaBase())));


            System.Console.WriteLine(facade.pedido.descricao);
            System.Console.WriteLine("valor carga: " + facade.pedido.valorCarga + "\n");

            SensorTemperatura.Instancia.SetTemperatura(85);
            

            AcessoCarga acesso = new Proxy("USER", facade.pedido);
            acesso.MostrarCustos();
            AcessoCarga acesso2 = new Proxy("ADMIN", facade.pedido);
            acesso2.MostrarCustos();
        }
    }
}
