using System;


namespace Instruccion_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Table , Suma, Division, Resta;
            Table = 0;
            Suma = 0;
            Division = 0;
            Resta = 0;

            Console.Write("Ingrese un numero para definir la tabla de Multiplicar: ");
            Table = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero para definir la tabla de Sumar: ");
            Suma = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero para definir la tabla de Division: ");
            Division = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero para definir la tabla de Resta: ");
            Resta = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("****************************************************************************************");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Table + " X " + i + " = " + (Table * i));
            }

            Console.WriteLine("****************************************************************************************");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Suma + " + " + i + " = " + (Suma + i));
            }

            Console.WriteLine("****************************************************************************************");


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Division + " / " + i + " = " + ((double)Division / i));
            }

            Console.WriteLine("****************************************************************************************");



            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Resta + " - " + i + " = " + (Resta - i));
            }

            Console.WriteLine("****************************************************************************************");


            Console.ReadKey();
        }
    }
}
