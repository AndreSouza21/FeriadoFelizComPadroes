using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class LogSistema
    {
        private static LogSistema instancia;

        private LogSistema() { }

        public static LogSistema Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new LogSistema();
                return instancia;
            }
        }

        public void Registrar(string mensagem)
        {
            Console.WriteLine($"[LOG] {mensagem}");
        }
    }
}
