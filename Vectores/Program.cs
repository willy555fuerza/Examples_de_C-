using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] Mes = { "Enero" , "Febrero" , "Marzo" , "Abril" , "Mayo" , "Junio" , "Julio" , "Agosto" , "Septiembre" , "Octubre" , "Noviembre" , "Diciembre" };
            double[] Sueldo = { 1500, 2100, 2500, 2700, 3000, 4500, 5100, 5500 ,5700 ,6000 ,6700, 7000 };
            int[] Num = { 1, 3, 5, 7, 9, 10, 30 , 50, 70, 90, 100, 120};
            bool[] Casado = { true ,false, false ,false , true , false, true ,true , false, false, true, false};

            for (int i = 0; i < Mes.Length; i++)
            {
                Console.WriteLine("CONTENIDO DEL VECTOR NOMBRES EN EL INDICE " + i + " es: " + Mes[i]);
            }

            Console.WriteLine("**********************************************************************************************");

            for (int i = 0; i < Sueldo.Length; i++)
            {
                Console.WriteLine("CONTENIDO DEL VECTOR SUELDOS EN EL INDICE " + i + " es: " + Sueldo[i]);
            }

            Console.WriteLine("**********************************************************************************************");

            for (int i = 0; i < Casado.Length; i++)
            {
                Console.WriteLine("CONTENIDO DEL VECTOR CASADOS EN EL INDICE " + i + " es: " + Casado[i]);
            }

            Console.WriteLine("**********************************************************************************************");

            Console.ReadKey();
        }
    }
}
