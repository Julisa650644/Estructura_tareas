using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
        
        if (EstaBalanceada(expresion))
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula NO balanceada.");
        }
    }

    static bool EstaBalanceada(string texto)
    {
        // Creamos una pila de caracteres
        Stack<char> pila = new Stack<char>();

        foreach (char c in texto)
        {
            // 1. Si es apertura, lo guardamos en la pila
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            // 2. Si es cierre, verificamos
            else if (c == ')' || c == ']' || c == '}')
            {
                // Si intentamos cerrar pero la pila está vacía, no está balanceada
                if (pila.Count == 0) return false;

                char ultimoApertura = pila.Pop();

                // Comprobamos que el de cierre coincida con el de apertura
                if (c == ')' && ultimoApertura != '(') return false;
                if (c == ']' && ultimoApertura != '[') return false;
                if (c == '}' && ultimoApertura != '{') return false;
            }
        }

        // Si al final la pila tiene 0 elementos, todo cuadró perfectamente
        return pila.Count == 0;
    }
}