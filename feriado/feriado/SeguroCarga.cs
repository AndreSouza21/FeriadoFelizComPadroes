using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class SeguroCarga : DecoradorCarga
    {
        public SeguroCarga(Carga carga) : base(carga) { }

        public override string Descricao()
            => carga.Descricao() + " + Seguro";

        public override double Custo()
            => carga.Custo() + 60;
    }
}
