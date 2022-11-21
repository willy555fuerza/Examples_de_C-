using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabales_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            const double Sueldo = 2700;

            dynamic Contenido;

            Contenido = true;

            Nombre = "Willy";
            Edad = 27;
           

            Console.WriteLine("Mi nombre es: " + Nombre + " Mi Edad es: " + Edad + " y Teniendo el Sueldo es : " + Sueldo);
            Console.WriteLine("Contenido: " + Contenido);
            Console.ReadKey();
        }
    }
}
