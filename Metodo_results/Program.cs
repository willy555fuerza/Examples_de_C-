using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_results
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nombre;
            double PagoxDias;
            int Dias;
            bool LePagaron;


            Console.Write("Ingresa Tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("*************************************************************************************************************************");

            Console.Write("Cuanto te Pagan por Dias Trabajado: ");
            PagoxDias = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************************************************************");

            Console.Write("Cuantos Dias Trabajaste: ");
            Dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************************************************");

            Console.Write("Le Pagaron Puntual: ");
            LePagaron = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("*************************************************************************************************************************");


            Console.WriteLine("El dinero Obtenidos por los dias trabajados es: " + CalcularTotal(PagoxDias, Dias));

            Console.WriteLine("*************************************************************************************************************************");

            Console.ReadKey();
        }


        static double CalcularTotal(double D1 ,int D2)
        {
            double Total;
            Total = (D1 * D2);
            return Total;
        }
    }
}
