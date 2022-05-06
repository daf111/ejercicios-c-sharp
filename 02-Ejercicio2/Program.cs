using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero mayor a 1");

            string valorIngresado = Console.ReadLine();
            
            if (ValidarNumeroIngresado(valorIngresado) == false)
            {
                Console.WriteLine("El valor ingresado NO es un número");
                System.Environment.Exit(1);
            }

            int number = int.Parse(valorIngresado);

            if (ValidarNumeroMayorAUno(number) == false)
            {
                Console.WriteLine("El valor ingresado DEBE ser mayor a 1");
                System.Environment.Exit(1);
            }

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            };
        }

        static bool ValidarNumeroIngresado(string valorIngresado)
        {
            string expresionRegular = @"^[0-9]+$";
            if (Regex.IsMatch(valorIngresado, expresionRegular) == false)
            {
                //Console.WriteLine("El valor ingresado NO es un número");
                //System.Environment.Exit(1);
                return false;
            }

            return true;
        }

        static bool ValidarNumeroMayorAUno(int valorIngresado)
        {
            if (valorIngresado <= 1)
            {
                //Console.WriteLine("El valor ingresado DEBE ser mayor a 1");
                //System.Environment.Exit(2);
                return false;
            }

            return true;
        }
    }
}
