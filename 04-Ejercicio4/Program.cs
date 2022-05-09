using System;

namespace _04_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer lado inferior");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado inferior");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer lado mayor");
            int lado3 = int.Parse(Console.ReadLine());

            /*
             * 1- Buscar que lados son los inferiores y cual es el mayor
             * 2- Sumar los dos lados inferiores
             * 3- Comparar que la sumatoria de los dos lados inferiores sea mayor al lado superior
             */

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("Es un triangulo isosceles");

            }
            else
            {
                Console.WriteLine("Es un triangulo escaleno");
            }
        }
    }
}
