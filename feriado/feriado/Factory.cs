using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Factory
    {
        public static Transportadora Criar(string tipo)
        {
            switch (tipo)
            {
                case "rodoviaria":
                    return new Rodoviaria();
                case "aerea":
                    return new Aerea();
                default:
                    return null;
            }
        }
    }
}
