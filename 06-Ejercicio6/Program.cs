using System;

namespace _06_Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Ingrese el dividiendo (número al que se divide)");
                int dividiendo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor (número que divide)");
                int divisor = int.Parse(Console.ReadLine());

                Console.WriteLine("El resultado de la division es " + dividiendo / divisor);
            }
            catch (System.DivideByZeroException exception)
            {
                Console.WriteLine("No se puede dividir por cero. " + exception.Message);
            }
            catch(System.FormatException exception)
            {
                Console.WriteLine("Imposible parsear el valor ingresado a número. " + exception.Message);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
