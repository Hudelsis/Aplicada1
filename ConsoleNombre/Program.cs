using System;

namespace ConsoleNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hudelsis Antigua Mendez");

            int edad = 20;
            Console.WriteLine(edad);

            //hacer un programa que transforma entre dolares y euros y que tambien pida el tipo de cambio del dia.//
            Console.WriteLine();
            double cantdolares, tipocambio, canteuro;

            Console.WriteLine("Ingrese cantidad de dolares: ");
            cantdolares = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tipo de cambio:");
            tipocambio = double.Parse(Console.ReadLine());

            canteuro = cantdolares * tipocambio;

            Console.WriteLine("Equivalente en Euros: {0}", canteuro);
            Console.WriteLine();

            //hacer un programa que transforma de grado a radianes.//
            Console.WriteLine();
            double grado, radianes, pi = 3.1416;
            string Valor = "";

            // pedir los grado
            Console.WriteLine("Ingrese la Cantidad de grado a convertir ");
            Valor = Console.ReadLine();
            grado = Convert.ToDouble(Valor);

            radianes = gradosRadianes(grado, pi);

            Console.WriteLine("{0} equivale a {1} radianes", grado, radianes);

            static double gradosRadianes(double n1, double n2)
            {
                double r = 0.0;
                r = (n1 * n2) / 180;

                return r;



            }

            ///Numero Par y Impar
            Console.WriteLine();
            int num = 0;

            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            if (num % 20 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
                Console.ReadKey();
            }
            Console.WriteLine();

            //// Dia de Semana//
            int num1;
            string linea;
            Console.WriteLine();
            Console.WriteLine("DIAS DE LA SEMANA");
            Console.WriteLine();
            Console.Write("Ingrese un numero del 1 al 7 :");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            switch (num1)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia DOMINGO");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia LUNES");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia MARTES");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia MIERCOLES");
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia JUEVES");
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia VIERNES");
                    break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia SABADO");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso esta fuera de rango");
                    break;
            }
            Console.ReadKey();

        }
    }
}
