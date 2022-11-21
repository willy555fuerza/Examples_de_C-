using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;
            bool Resultado;
            a = 15;
            b = 15;
            c = 0;
            d = 205;
            Resultado = !(a == b) || (c == d);

            Console.WriteLine("Cual es el Resultado de (a == b) && (c<d): " + Resultado);
            Console.ReadKey();
        }
    }
}
