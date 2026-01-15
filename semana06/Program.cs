using System;                    
using semana06;                  

namespace semana06                 // Define el espacio de nombres del proyecto.
{
    class Program                  // Clase principal del programa.
    {
        static void Main(string[] args)   // Método de entrada: aquí comienza la ejecución.
        {
            // Ejercicio 1: Invertir lista enlazada de enteros
            Ejercicio1 listaEnteros = new Ejercicio1();   // Crea objeto de la clase Ejercicio1.
            listaEnteros.DemoInvertirLista();             // Llama al método que muestra la inversión de la lista.

            Console.WriteLine("\n----------------------------\n"); // Imprime separador en consola.

            // Ejercicio 2: Registro de vehículos
            Ejercicio2 registroVehiculos = new Ejercicio2();       // Crea objeto de la clase Ejercicio2.
            registroVehiculos.DemoRegistroVehiculos();             // Llama al método que muestra el registro de vehículos.
        }
    }
}
