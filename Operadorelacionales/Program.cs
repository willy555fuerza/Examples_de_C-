using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadorelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            bool Operaciones;

            Num1 = 10;
            Num2 = 15;

            Operaciones = (Num1 != Num2);

            Console.Write("Num1 es distinto que Num2? " + Operaciones);
            Console.ReadKey();
        }
    }
  
}
