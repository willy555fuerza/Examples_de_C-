using System;


namespace Estructura_ciclica_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Correlativo, multi,triple,cuart, quint, sext, sept, oct, nov, dec;
            Correlativo = 0;
            multi = 0; 
            triple = 0;
            cuart = 0;
            quint = 0;
            sext = 0;       
            sept = 0;   
            oct = 0;
            nov = 0;
            dec = 0;

            Console.WriteLine("La tabla del #1 ");
            Console.WriteLine("La tabla del #2 ");
            Console.WriteLine("La tabla del #3 ");
            Console.WriteLine("La tabla del #4 ");
            Console.WriteLine("La tabla del #5 ");
            Console.WriteLine("La tabla del #6 ");
            Console.WriteLine("La tabla del #7 ");
            Console.WriteLine("La tabla del #8 ");
            Console.WriteLine("La tabla del #9 ");
            Console.WriteLine("La tabla del #10 ");
            Console.WriteLine("*************************************************");


            while (Correlativo<=10)
            {

                Console.WriteLine(" 1 x " + Correlativo + " = " + (1 * Correlativo));
                Correlativo++;
            }

            Console.WriteLine("*************************************************");

            while (multi <= 10)
            {

                Console.WriteLine(" 2 x " + multi + " = " + (2 * multi));
                multi++;
            }

            Console.WriteLine("*************************************************");

            while (triple <= 10)
            {

                Console.WriteLine(" 3 x " + triple + " = " + (3 * triple));
                triple++;
            }

            Console.WriteLine("*************************************************");

            while (cuart <= 10)
            {

                Console.WriteLine(" 4 x " + cuart + " = " + (4 * cuart));
                cuart++;
            }

            Console.WriteLine("*************************************************");

            while (quint <= 10)
            {

                Console.WriteLine(" 5 x " + quint + " = " + (5 * quint));
                quint++;
            }

            Console.WriteLine("*************************************************");

            while (sext <= 10)
            {

                Console.WriteLine(" 6 x " + sext + " = " + (6 * sext));
                sext++;
            }

            Console.WriteLine("*************************************************");

            while (sept <= 10)
            {

                Console.WriteLine(" 7 x " + sept + " = " + (7 * sept));
                sept++;
            }

            Console.WriteLine("*************************************************");

            while (oct <= 10)
            {

                Console.WriteLine(" 8 x " + oct + " = " + (8 * oct));
                oct++;
            }

            Console.WriteLine("*************************************************");

            while (nov <= 10)
            {

                Console.WriteLine(" 9 x " + nov + " = " + (9 * nov));
                nov++;
            }

            Console.WriteLine("*************************************************");

            while (dec <= 10)
            {

                Console.WriteLine(" 10 x " + dec + " = " + (10 * dec));
                dec++;
            }

            Console.ReadKey();
        }
    }
}
