using System;
using System.Collections.Generic;

namespace semana05
{
    public class Ejercicio5
    {
        public void MostrarNumerosInversos()
        {
            Console.WriteLine("EJERCICIO 5: NÚMEROS DEL 1 AL 10 INVERSOS");
            List<int> numeros = new List<int>();

            for (int i = 1; i <= 10; i++) numeros.Add(i);

            Console.Write("Resultado: ");
            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                Console.Write(numeros[i]);
                if (i > 0) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
