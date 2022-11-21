using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngresarDatos();
            Console.ReadKey();
        }

        // METODOS SIMPLES

        static void IngresarDatos()
        {
            string Nombre;
            int Edad;
            double Sueldo;
            bool Soltera;

            Console.Write("Ingresa Tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("*********************************************************************************************");

            Console.Write("Ingresa Tu Edad: ");
            Edad =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*********************************************************************************************");

            Console.Write("Ingresa Tu Sueldo: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("*********************************************************************************************");

            Console.Write("Ingresa Tu Estado Civil: ");
            Soltera = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("*********************************************************************************************");


            Console.WriteLine("Tu Nombre es: " + Nombre);


            Console.WriteLine("*********************************************************************************************");


            Console.WriteLine("Tu Edad es: " + Edad);


            Console.WriteLine("*********************************************************************************************");

            Console.WriteLine("Tu Sueldo es: " + Sueldo);


            Console.WriteLine("*********************************************************************************************");

            Console.WriteLine("Tu Estado Civil: " + Soltera);


            Console.WriteLine("*********************************************************************************************");

        }

    }
}
