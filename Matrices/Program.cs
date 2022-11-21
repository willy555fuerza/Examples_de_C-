using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[7, 2];
            bool [,] Casada = new bool[7, 1];
            double [,] Sueldo = new double[7, 1];
            int[,] Num = new int[7, 1];

            Persona[0, 0] = "NELZY";
            Persona[0, 1] = "RALDE";

            Persona[1, 0] = "BELEN";
            Persona[1, 1] = "SAA";

            Persona[2, 0] = "LUZ";
            Persona[2, 1] = "APAZA";

            Persona[3, 0] = "MADAI";
            Persona[3, 1] = "ANTEZANA";

            Persona[4, 0] = "YOSELIN";
            Persona[4, 1] = "RODRIGUEZ";

            Persona[5, 0] = "SARA";
            Persona[5, 1] = "CUELLAR";

            Persona[6, 0] = "REBECA";
            Persona[6, 1] = "YARARI";

            Console.WriteLine("*********************************************************************************************");

            Casada[0, 0] =  true ;
            //Casada[0, 1] =  false ;

            Casada[1, 0] = false;
            //Casada[1, 1] = false;

            Casada[2, 0] = true;
            //Casada[2, 1] = true;

            Casada[3, 0] = false;
            //Casada[3, 1] = true;

            Casada[4, 0] = true;
            //Casada[4, 1] = false;

            Casada[5, 0] = false;
            //Casada[5, 1] = false;

            Casada[6, 0] = true;
            //Casada[6, 1] = true;

            Console.WriteLine("*********************************************************************************************");

            Sueldo[0, 0] = 1500;
            //Sueldo[0, 1] = 1700;

            Sueldo[1, 0] = 1700;
            //Sueldo[1, 1] = 1700;

            Sueldo[2, 0] = 2100;
            //Sueldo[2, 1] = 2100;

            Sueldo[3, 0] = 2500;
            //Sueldo[3, 1] = 2500;

            Sueldo[4, 0] = 2700;
            //Sueldo[4, 1] = 2700;

            Sueldo[5, 0] = 3100;
            //Sueldo[5, 1] = 3100;

            Sueldo[6, 0] = 3700;
            //Sueldo[6, 1] = 3700;

            Console.WriteLine("*********************************************************************************************");

            Num[0, 0] = 30;
            

            Num[1, 0] = 50;
            

            Num[2, 0] = 70;
            

            Num[3, 0] = 90;
            

            Num[4, 0] = 110;
            

            Num[5, 0] = 130;
            

            Num[6, 0] = 150;
            

            Console.WriteLine("*********************************************************************************************");


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Persona [" + i + "] = " + Persona[i,0] + " " + Persona[i,1]);
            }

            Console.WriteLine("*********************************************************************************************");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Casada [" + i + "] = " + Casada[i, 0] + " " );
            }

            Console.WriteLine("*********************************************************************************************");


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Sueldo [" + i + "] = " + Sueldo[i, 0] + " " );
            }

            Console.WriteLine("*********************************************************************************************");


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Numero [" + i + "] = " + Num[i, 0] + " ");
            }

            Console.WriteLine("*********************************************************************************************");

            Console.ReadKey();
        }
    }
}
