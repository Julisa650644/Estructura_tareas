using System;
using System.Collections.Generic;

class HanoiPilas
{
    // Creamos las 3 torres como pilas globales
    static Stack<int> torreA = new Stack<int>();
    static Stack<int> torreB = new Stack<int>();
    static Stack<int> torreC = new Stack<int>();

    static void Main()
    {
        int discos = 3;
        // Llenamos la torre A: el 3 abajo, luego el 2, luego el 1 arriba
        for (int i = discos; i >= 1; i--) torreA.Push(i);

        Console.WriteLine("Movimientos con Pilas:");
        ResolverHanoi(discos, torreA, torreC, torreB, 'A', 'C', 'B');
    }

    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> aux, char nombreOr, char nombreDest, char nombreAux)
    {
        if (n > 0)
        {
            // Mover n-1 discos al auxiliar
            ResolverHanoi(n - 1, origen, aux, destino, nombreOr, nombreAux, nombreDest);

            // Mover el disco actual
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOr} a {nombreDest}");

            // Mover n-1 discos del auxiliar al destino
            ResolverHanoi(n - 1, aux, destino, origen, nombreAux, nombreDest, nombreOr);
        }
    }
}