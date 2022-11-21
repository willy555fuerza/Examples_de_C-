using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            try
            {
                Console.Write("Ingresa Tu Edad: ");
                Edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception luz) 
            {
                Console.WriteLine("ERROR: " + luz.Message);
            }
            Console.ReadKey();
        }
    }
}
