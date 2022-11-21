using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicinesif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            double sueldo;
            bool Extranjero;

            Console.Write("Ingresa Tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingresa Tu Edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa Tu Sueldo: " );
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("sos extranjero: ");
            Extranjero = Convert.ToBoolean(Console.ReadLine());

            //El  sueldo minimo en Bolivia es  menor o igual 2200
            // Tu sueldo es mayor a 2200 y menor igual a 2700, tu sueldo es rentable
            // El sueldo ingresado es mayor a 2700, tu sueldo es generoso
           
            if (sueldo <= 2200)
            {
                Console.WriteLine(Nombre + ", Tiene " + Edad + " Años" + ", Su sueldo es el minimo que tiene en Bolivia " + ", Extranjer@ " + Extranjero );
            }
            else if (sueldo > 2200 && sueldo <= 2700)
          
            {
                Console.WriteLine(Nombre + ", Tiene " + Edad + " Años" +  ", Su sueldo es Rentable" + ", Extranjer@ " +  Extranjero );
            }
            else if (sueldo > 2700)
            {
                Console.WriteLine(Nombre + ", Tiene " + Edad + " Años" + ",Su Sueldo es Generoso " + ", Extranjer@ " + Extranjero);
            }
            Console.ReadKey();
        }
    }
}
