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
        private CargaReal real = new CargaReal();

        public Proxy(string usuario)
        {
            this.usuario = usuario;
           
        }

        public void MostrarCustos()
        {
            if (usuario == "ADMIN")
                real.MostrarCustos();
            else
                Console.WriteLine("Acesso negado!");
        }
    }
}
