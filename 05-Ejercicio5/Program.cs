using System;

namespace _05_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Hola, escribí una frase, por favor.");
            do
            {
                cadena = Console.ReadLine();
            }
            while (cadena.Length >= 20);

            char letra;
            int contador = 0;

            cadena = cadena.ToLower();
            for (int indice = 0; indice < cadena.Length; indice++)
            {
                letra = cadena[indice];

                if (EsVocal(letra))
                {
                    contador++;
                }

            }

            Console.WriteLine(contador);
        }

        static bool EsVocal(char letra)
        {
            return (
                letra == 'a' ||
                letra == 'e' ||
                letra == 'i' ||
                letra == 'o' ||
                letra == 'u'
           );
        }
    }
}
