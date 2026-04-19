using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal abstract class DecoradorCarga : Carga
    {
        protected Carga carga;

        public DecoradorCarga(Carga carga)
        {
            this.carga = carga;
        }

        public virtual string Descricao() => carga.Descricao();
        public virtual double Custo() => carga.Custo();
    }
}
