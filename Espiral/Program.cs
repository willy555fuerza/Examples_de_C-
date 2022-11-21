using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caracol
{
       namespace Caracol
    {
        class Caracol
        {

            enum Direccion { DERECHA, ABAJO, IZQUIERDA, ARRIBA };

            static void Main(string[] args)
            {
                int row, columnas, will, column, i = 1;
                Console.Write("Ingrese el n\u00FAmero de renglones: ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el n\u00FAmero de columnas : ");
                columnas = int.Parse(Console.ReadLine());
                int[,] matriz = new int[row, columnas];
                for (will = 0; will < row; will++)
                    for (column = 0; column < columnas; column++)
                        matriz[will, column] = -1;
                will = 0;
                column = 0;
                Direccion d = Direccion.DERECHA;
                while (matriz[will, column] == -1)
                {
                    matriz[will, column] = i;
                    i++;
                    switch (d)
                    {
                        case Direccion.DERECHA:
                            if (column + 1 < columnas && matriz[will, column + 1] == -1)
                                column++;
                            else
                            {
                                d = Direccion.ABAJO;
                                will++;
                            }
                            break;
                        case Direccion.ABAJO:
                            if (will + 1 < row && matriz[will + 1, column] == -1)
                                will++;
                            else
                            {
                                d = Direccion.IZQUIERDA;
                                column--;
                            }
                            break;
                        case Direccion.IZQUIERDA:
                            if (column > 0 && matriz[will, column - 1] == -1)
                                column--;
                            else
                            {
                                d = Direccion.ARRIBA;
                                will--;
                            }
                            break;
                        case Direccion.ARRIBA:
                            if (will > 0 && matriz[will - 1, column] == -1)
                                will--;
                            else
                            {
                                d = Direccion.DERECHA;
                                column++;
                            }
                            break;
                    }
                }
                Console.WriteLine("\nResultado:");
                for (will = 0; will< row; will++)
                {
                    Console.Write("[");
                    for (column = 0; column < columnas; column++)
                        Console.Write("  {0,3}", matriz[will, column]);
                    Console.WriteLine("  ]");
                }
                Console.Write("\nPresione una tecla para terminar . . . ");
                Console.ReadKey();
            }

        }
    }
}
