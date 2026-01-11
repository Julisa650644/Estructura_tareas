using System;
using semana05;

namespace semana05
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1 tareaVocales = new Ejercicio1();
            tareaVocales.MostrarVocales();

            Console.WriteLine("\n----------------------------\n");

            Ejercicio2 validadorPalindromo = new Ejercicio2();
            validadorPalindromo.VerificarPalindromo();

            Console.WriteLine("\n----------------------------\n");

            Ejercicio3 calculadoraVectores = new Ejercicio3();
            calculadoraVectores.MostrarProductoEscalar();

            Console.WriteLine("\n----------------------------\n");

            Ejercicio4 gestorAsignaturas = new Ejercicio4();
            gestorAsignaturas.MostrarAsignaturasConMensaje();

            Console.WriteLine("\n----------------------------\n");

            Ejercicio5 listaInversa = new Ejercicio5();
            listaInversa.MostrarNumerosInversos();
        }
    }
}
