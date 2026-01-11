using System;
using System.Collections.Generic;

namespace semana05
{
    public class Ejercicio4
    {
        public void MostrarAsignaturasConMensaje()
        {
            Console.WriteLine("EJERCICIO 4: LISTA DE ASIGNATURAS");
            List<string> materias = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            foreach (string m in materias)
            {
                Console.WriteLine("Yo estudio " + m);
            }
        }
    }
}
