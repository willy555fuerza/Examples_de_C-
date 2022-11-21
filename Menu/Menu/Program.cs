using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1: Los 38 ejercicios");
            Console.WriteLine("2: Vectores");
            Console.WriteLine("3: Matrices");
            Console.WriteLine("digite la opcion");

            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.Clear();

                    double a, b;
                    int opcion;
                    Console.WriteLine("Menu de opciones");
                    Console.WriteLine("1: Suma (a+b)");
                    Console.WriteLine("2: Resta (a-b)");
                    Console.WriteLine("3: Multiplicacion (a*b)");
                    Console.WriteLine("4: Division (a/b)");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("5: Area de un triangulo");
                    Console.WriteLine("6: Area de un cuadrado");
                    Console.WriteLine("7: Hallar la hipotenusa de un triangulo");
                    Console.WriteLine("8: Hallar el cateto faltante de un triangulo");
                    Console.WriteLine("9: Hallar el cateto adyasente");
                    Console.WriteLine("10: Hallar el perimetro de un triangulo");
                    Console.WriteLine("11: Hallar el area de un circulo");
                    Console.WriteLine("12: Hallar el volumen de un cilindro");
                    Console.WriteLine("13: Hallar el area de un rombo");
                    Console.WriteLine("14: Hallar el mayor de 2 numeros");
                    Console.WriteLine("0: Salir");
                    Console.WriteLine("digite la opcion");

                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("digite el valor de a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de b: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("la suma de {0} + {1} = {2}", a, b, (a + b));
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("digite el valor de a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de b: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("la suma de {0} - {1} = {2}", a, b, (a - b));
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("digite el valor de a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de b: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("la suma de {0} * {1} = {2}", a, b, (a * b));
                            break;
                        case 4:
                            Console.Clear();
                            Console.Write("digite el valor de a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de b: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("la suma de {0} / {1} = {2}", a, b, (a / b));
                            break;
                        case 5:
                            Console.Clear();
                            double h;
                            Console.Write("digite el valor de base:  ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de la altura: ");
                            h = Convert.ToDouble(Console.ReadLine());
                            a = (b * h) / 2;
                            Console.WriteLine("El area del triangulo es: {0} ", a);
                            break;
                        case 6:
                            Console.Clear();
                            Console.Write("digite el valor de la base:  ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de la altura: ");
                            h = Convert.ToDouble(Console.ReadLine());
                            a = (b * h);
                            Console.WriteLine("El area del cuadrado es: {0} ", a);
                            break;
                        case 7:
                            Console.Clear();
                            Console.Write("digite el valor de la altura:  ");
                            h = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de la base: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            a = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(b, 2));
                            Console.WriteLine("lA Hipotenusa de un  triangulo es: {0} ", a);
                            break;
                        case 8:
                            Console.Clear();
                            Console.Write("digite el valor de la hoptenusa:  ");
                            h = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor del cateto: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            a = Math.Sqrt(Math.Pow(h, 2) - Math.Pow(b, 2));
                            Console.WriteLine("Hallar el cateto del traingulo: {0} ", a);
                            break;
                        case 9:
                            Console.Clear();
                            Console.Write("digite el valor de la altura:  ");
                            h = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de la hipotenusa: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            a = Math.Sqrt(Math.Pow(h, 2) - Math.Pow(b, 2));
                            Console.WriteLine("Hallar el cateto adyasente es: {0} ", a);
                            break;
                        case 10:
                            Console.Clear();
                            Console.Write("digite el valor de la altura:  ");
                            b = Convert.ToDouble(Console.ReadLine());
                            a = 2 * 3.1416 * b;
                            Console.WriteLine("Hallar el perimitro de un triangulo: {0} ", a);
                            break;
                        case 11:
                            Console.Clear();
                            Console.Write("digite el valor de la altura:  ");
                            b = Convert.ToDouble(Console.ReadLine());
                            a = 3.1416 * (Math.Pow(b, 2));
                            Console.WriteLine("Hallar el area de un circulo: {0} ", a);
                            break;
                        case 12:
                            Console.Clear();
                            Console.Write("digite el valor de base:  ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de la altura: ");
                            h = Convert.ToDouble(Console.ReadLine());
                            a = 3.1416 * h * (Math.Pow(b, 2));
                            Console.WriteLine("Hallar el volumen de un cilindro: {0} ", a);
                            break;
                        case 13:
                            Console.Clear();
                            Console.Write("digite el valor de base:  ");
                            h = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor de la altura: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            a = (h * b) / 2;
                            Console.WriteLine("Hallar el area de un rombo: {0} ", a);
                            break;
                        case 14:
                            Console.Clear();
                            Console.Write("digite el valor del primer numero:  ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("digite el valor del segundo numero: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            if (a > b)
                            {
                                Console.WriteLine("el numero mayor es: {0}", a);
                                Console.WriteLine("el numero menor es: {0}", b);
                            }
                            else
                            {
                                Console.WriteLine("el numero mayor es: {0}", a);
                                Console.WriteLine("el numero menor es: {0}", b);
                            }

                            break;


                        case 0:
                            Console.WriteLine("chauuu.......");
                            break;
                        default:
                            Console.WriteLine("valor incorrecto");

                            break;
                    }
                    break;
                case 2:
                    Console.Clear();

                    int d;

                    Console.WriteLine("Menu de opciones");
                    Console.WriteLine("1: numero par e impar");
                    Console.WriteLine("2: ................");
                    Console.WriteLine("3: ................");
                    Console.WriteLine("digite la opcion");

                    d = Convert.ToInt32(Console.ReadLine());

                    switch (d)
                    {
                        case 1:
                            Console.Clear();

                            int i, n;
                            Console.WriteLine("ingrese la cantida de numeros que quiere ingresar");
                            n = Convert.ToInt32(Console.ReadLine());
                            int[] vec = new int[n];
                            Console.WriteLine("ingre sus digitos");
                            for (i = 0; i < n; i++)
                            {
                                vec[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Los numeros pares son:");
                            for (i = 0; i < n; i++)
                            {
                                if (vec[i] % 2 == 0)
                                {
                                    Console.WriteLine(vec[i]);
                                }
                            }
                            Console.WriteLine("Los numeros impares son:");
                            for (i = 0; i < n; i++)
                            {
                                if (vec[i] % 2 != 0)
                                {
                                    Console.WriteLine(vec[i]);
                                }
                            }

                            break;
                    }
                    break;
                default:
                    Console.WriteLine("valor incorrecto");
                    break;
            }


            Console.ReadKey();
        }
    }
}
