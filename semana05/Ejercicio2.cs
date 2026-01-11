using System;

namespace semana05
{
    public class Ejercicio2
    {
        public void VerificarPalindromo()
        {
            Console.WriteLine("EJERCICIO 2: VERIFICAR PALÍNDROMO");
            Console.Write("Introduce una palabra: ");
            string palabra = Console.ReadLine()?.ToLower() ?? "";
            string inversa = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                inversa += palabra[i];
            }

            if (palabra == inversa && palabra != "")
                Console.WriteLine("Resultado: Es un palíndromo.");
            else
                Console.WriteLine("Resultado: No es un palíndromo.");
        }
    }
}
