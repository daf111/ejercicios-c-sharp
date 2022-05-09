using System;

namespace _03_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero (0 para finalizar): ");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
            } while (numero != 0);

            Console.WriteLine("La sumatoria de los numeros ingresados es: " + suma);
        }
    }
}
