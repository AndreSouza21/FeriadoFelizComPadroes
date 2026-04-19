using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class CargaReal : AcessoCarga
    {
        private double valorFrete;
        private double valorCarga;
        private string descricaoCarga;
        public CargaReal(double frete, double carga, string desc) 
        {
            this.valorFrete = frete;
            this.valorCarga = carga;
            this.descricaoCarga = desc;
        }


        public void MostrarCustos()
        {
            Console.WriteLine("\nresumo pedido:");
            Console.WriteLine($"{descricaoCarga}");
            Console.WriteLine($"valor do frete: {valorFrete:F2}");
            Console.WriteLine($"valor da carga: {valorCarga:F2}");
            Console.WriteLine($"valor total: {valorFrete + valorCarga:F2}");
        }
    }
}
