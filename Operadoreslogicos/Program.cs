using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadoreslogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b, c, d;
            bool Resultado;
            a = 10;
            b = 2;
            c = 0;
            d = 205;
            Resultado = !(a > b);

            Console.Write("Cual es el Resultado de (a == b) && (c>d) " + Resultado);
            Console.ReadKey();
        }
    }
}
