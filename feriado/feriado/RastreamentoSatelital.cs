using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class RastreamentoSatelital : DecoradorCarga
    {
        public RastreamentoSatelital(Carga carga) : base(carga) { }

        public override string Descricao()
            => carga.Descricao() + " + Rastreamento";

        public override double Custo()
            => carga.Custo() + 40;
    }
}
