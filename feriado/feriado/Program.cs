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

            Carga carga = new SeguroCarga(
                                new RastreamentoSatelital(
                                    new CargaBase()));
            
            System.Console.WriteLine(carga.Descricao());
            System.Console.WriteLine(carga.Custo());

            AcessoCarga acesso = new Proxy("ADMIN");
            acesso.MostrarCustos();
        }
    }
}
