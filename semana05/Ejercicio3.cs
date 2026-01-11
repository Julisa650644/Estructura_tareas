using System;
using System.Collections.Generic;

namespace semana05
{
    public class Ejercicio3
    {
        public void MostrarProductoEscalar()
        {
            Console.WriteLine("EJERCICIO 3: PRODUCTO ESCALAR");
            List<int> v1 = new List<int> { 1, 2, 3 };
            List<int> v2 = new List<int> { -1, 0, 2 };

            int resultado = (v1[0] * v2[0]) + (v1[1] * v2[1]) + (v1[2] * v2[2]);

            Console.WriteLine("Vectores: (1,2,3) y (-1,0,2)");
            Console.WriteLine("El producto escalar es: " + resultado);
        }
    }
}
