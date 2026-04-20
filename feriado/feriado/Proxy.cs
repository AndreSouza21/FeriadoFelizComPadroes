using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Proxy : AcessoCarga
    {
        private string usuario;
        private CargaReal real;
        

        public Proxy(string usuario, Pedido pedi)
        {
            this.usuario = usuario;
            real = new CargaReal(pedi.valorFrete, pedi.valorCarga, pedi.descricao,pedi.distancia);
        }

        public void MostrarCustos()
        {
            if (usuario == "ADMIN")
                real.MostrarCustos();
            else
                Console.WriteLine("\nAcesso negado!");
        }
    }
}
