using System;


namespace Estructura_ciclica_de_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Numero = 0;

            do
            {
                Console.WriteLine("El valor de variable Numero es: " + Numero);
                Numero++;

            } while (Numero <= 100);
            Console.ReadKey();
        }
    }
}
