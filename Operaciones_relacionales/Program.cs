using System;

namespace Operaciones_relacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            bool Operaciones;

            Num1 = 5;
            Num2 = 7;
            Operaciones = (Num1 != Num2);

            Console.WriteLine("Num1 es distinto que Num2?" + Operaciones);
            Console.ReadKey();  
        }
    }
}
