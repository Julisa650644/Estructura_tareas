using System;

namespace semana05
{
    public class Ejercicio1
    {
        public void MostrarVocales()
        {
            Console.WriteLine("EJERCICIO 1: CONTADOR DE VOCALES");
            Console.Write("Introduce una palabra: ");
            string palabra = Console.ReadLine()?.ToLower() ?? "";
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char v in vocales)
            {
                int contador = 0;
                foreach (char letra in palabra)
                {
                    if (letra == v) contador++;
                }
                Console.WriteLine($"La vocal '{v}' aparece: {contador} veces.");
            }
        }
    }
}
