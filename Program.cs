using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)

        {
         
            //Ejercicio clase 10
            //Pograma para mostrar mes según número

            //MENU
            Console.WriteLine("\n------Iniciando con el programa------\n");
            Console.WriteLine("Ingrese un número para mostrar el mes: \n");
            
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
                {
                    case 1:
                        Console.WriteLine("\n Usted ha ingresado el número " + num + " y corresponde al mes de Enero");
                        Console.WriteLine("\n------Fin del programa Programa------\n");

                        break;
                    case 2:
                        Console.WriteLine("\n Usted ha ingresado el número " + num + " y corresponde al mes de Febrero");
                        Console.WriteLine("\n------Fin del Programa------\n");
                        break;
                    case 3:
                        Console.WriteLine("\n Usted ha ingresado el número " + num + " y  corresponde al mes de Marzo");
                         Console.WriteLine("\n------Fin del Programa------\n");
                        break;
                    case 4:
                        Console.WriteLine("\n Usted ha ingresado el número " + num + " y  corresponde al mes de Abril");
                        Console.WriteLine("\n------Fin del Programa------\n");
                        break;
                    case 5:
                        Console.WriteLine("\n Usted ha ingresado número " + num + " y  corresponde al mes de Mayo");
                        Console.WriteLine("\n------Fin del Programa------\n");
                        break;
                    case 6:
                        Console.WriteLine("\n Usted ha ingresado el número" + num + " y  corresponde al mes de Junio");
                        Console.WriteLine("\n------Fin del programa------\n");
                        break;
                    default:
                        Console.WriteLine("\nEl número de mes que ha ingresado es incorrecto. Favor, intente nuevamente\n");
                        break;
                }
        }
    }
}