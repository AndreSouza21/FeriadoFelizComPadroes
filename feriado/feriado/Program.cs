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
            facade.Despachar("aerea", 100, new FreteExpresso());

            facade.SetCarga(new SeguroCarga(
                                new RastreamentoSatelital(
                                    new CargaBase())));


            System.Console.WriteLine(facade.pedido.descricao);
            System.Console.WriteLine("valor carga: " + facade.pedido.valorCarga);

            

            AcessoCarga acesso = new Proxy("ADMIN", facade.pedido);
            acesso.MostrarCustos();
        }
    }
}
