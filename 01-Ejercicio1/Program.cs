using System;
using System.Collections.Generic;

namespace _01_Ejercicio1
{
    class Program
    {

        static void Main(string[] args)
        {
            int divisor = 2;
            List<int> numeros = NumerosDivisiblesPorUnNumero(1000, divisor);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero + " es divisible por " + divisor);
            }
        }

        private static List<int> NumerosDivisiblesPorUnNumero(int numeroMaximo, int divisor)
        {
            List<int> numeros = new List<int>();
            
            //TODO: Solicitar este valor por teclado con Console.ReadLine
            //y validar que el valor ingresado sea un número
            //int divisor = 2;

            for (int i = 1; i <= numeroMaximo; i++)
            {
                if (i % divisor == 0)
                {
                    //Console.WriteLine(i + " es divisible por 3");
                    numeros.Add(i);
                }
            }

            return numeros;
        }
    }
}
