using System;
using System.Diagnostics.SymbolStore;

namespace Conversion_tipo_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            int Edad;
            bool Casado;
            double sueldo;

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su Edad: ");
            //Edad = int.Parse(Console.ReadLine());
            Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Eres casado?: ");
            //Casado = bool.Parse(Console.ReadLine());
            Casado = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingrese su Sueldo: ");
            //sueldo =double.Parse(Console.ReadLine());
            sueldo = Convert.ToDouble(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
