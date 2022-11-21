using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Example_con_parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OperacionMatematicas;
            int Operaciones;

            Console.Write("Quieres Realizar la Tabla de Multiplicar o Restar o Sumar?: ");
            OperacionMatematicas = Console.ReadLine();

            Console.Write("Que numero de Tabla desea que se Muestre: ");
            Operaciones = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************************************");

            if (OperacionMatematicas == "SUMAR")
            {
                Sumar(Operaciones);

            }
            else if (OperacionMatematicas == "MULTIPLICAR")
            {
                Multiplicar(Operaciones);
            }
            else if (OperacionMatematicas == "RESTA")
            {
                Resta(Operaciones);
            }else if (OperacionMatematicas == "DIVISION")
            {
                Division(Operaciones);
            }else
            {
                Console.WriteLine("Operacion_de_Matematca no valida");
            }
           
            

            Console.WriteLine("************************************************************");

            Console.ReadKey();
        }

        //METODO DE LA TABLA DE SUMAR

        static void Sumar(int Numero)
        {
            Console.WriteLine("************************************************************");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Numero + " + " + i + " = " + (Numero + i));
            }
        }

        //METODO DE LA TABLA DE MULTIPLICAR

        static void Multiplicar(int Numero)
        {
            Console.WriteLine("************************************************************");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Numero + " X " + i + " = " + (Numero * i));
            }
        }

        //METODO DE LA TABLA DE RESTA

        static void Resta(int Numero)
        {
            Console.WriteLine("************************************************************");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Numero + " - " + i + " = " + (Numero - i));
            }
        }

        //METODO DE LA TABLA DE DIVISION

        static void Division(int Numero)
        {
            Console.WriteLine("************************************************************");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Numero + " / " + i + " = " + ( Numero / i));
            }
        }
    }
}
