using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar_de_mayor_a_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 99, 78, 99, 674};
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;


                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
