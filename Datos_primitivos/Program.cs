using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_primitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            String nombre;
            double sueldo;
            bool casado;
           

            Console.Write("Cual es tu Nombre?: ");
            nombre=Console.ReadLine();

            Console.Write("Ingresa tu Edad: ");
            edad= Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa tu Sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Casado?: ");
            casado = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Tu nombre es " + nombre + " y tu edad es " + edad);
            Console.Write("Tu sueldo es " + sueldo + " y La Consulta de Casado es: " + casado);

            Console.ReadKey();


        }
    }
}
