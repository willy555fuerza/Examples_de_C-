using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_cero1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, num, fstars, fend, colstars, colend;
            Random rand = new Random();
            Console.WriteLine("Ingrese filas: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese columnas: ");
            m = int.Parse(Console.ReadLine());
            int[,] vec = new int[n, m];
            num = 0;
            fstars = 0;
            fend = n - 1;
            colstars = 0;
            colend = m - 1;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    vec[i, j] = rand.Next(1, 9);
                }
            }
            for (i = fstars; i <= fend; i++)
            {
                vec[i, colend] = num;
            }
            for (j = colstars; j <= colend; j++)
            {
                vec[fstars, j] = num;
            }
            for (i = fend; i >= fstars + 1; i--)
            {
                vec[i, colstars] = num;
            }
            for (j = colend; j >= colstars; j--)
            {
                vec[fend, j] = num;
            }
            rand.Next(2, 9);
            //mostrar
            for (i = 0; i <= n - 1; i++)
            {
                for (j = 0; j <= m - 1; j++)
                {
                    Console.Write("[" + vec[i, j] + "]");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
