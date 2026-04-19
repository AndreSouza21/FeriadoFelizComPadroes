using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class Pedido
    {
        public string descricao {  get; private set; }
        public double valorFrete { get; private set; }
        public double valorCarga { get; private set; }

        public Pedido(double frete)
        {
            this.valorFrete = frete;
        }

        public void setCarga(double valorCarga, string descricao)
        {
            this.valorCarga = valorCarga;
            this.descricao = descricao;
        }
    }
}
