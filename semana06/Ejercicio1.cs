using System;                     // Librería básica para usar consola.
namespace semana06                
{
    class Nodo                     // Clase que representa un nodo de la lista enlazada.
    {
        public int dato;           // Dato que guarda el nodo (entero).
        public Nodo siguiente;     // Referencia al siguiente nodo.

        public Nodo(int d)         // Constructor que inicializa el nodo con un valor.
        {
            dato = d;
            siguiente = null;      // Al inicio no apunta a nadie.
        }
    }

    class ListaEnlazada            // Clase que maneja la lista enlazada.
    {
        public Nodo cabeza;        // Primer nodo de la lista.

        public void Agregar(int d) // Método para agregar un nodo al final.
        {
            Nodo nuevo = new Nodo(d);   // Crea un nuevo nodo.
            if (cabeza == null)         // Si la lista está vacía...
                cabeza = nuevo;         // El nuevo nodo es la cabeza.
            else
            {
                Nodo temp = cabeza;     // Recorre la lista desde la cabeza.
                while (temp.siguiente != null) // Avanza hasta el último nodo.
                    temp = temp.siguiente;
                temp.siguiente = nuevo; // Conecta el nuevo nodo al final.
            }
        }

        public void Mostrar()      // Método para mostrar todos los nodos.
        {
            Nodo temp = cabeza;    // Empieza desde la cabeza.
            while (temp != null)   // Mientras haya nodos..
            {
                Console.Write(temp.dato + " - "); // Imprime el dato.
                temp = temp.siguiente;             // Avanza al siguiente nodo.
            }
            Console.WriteLine("null"); // Marca el final de la lista.
        }

        public void Invertir()     // Método para invertir la lista.
        {
            Nodo anterior = null;  // Nodo previo (inicia vacío).
            Nodo actual = cabeza;  // Nodo actual (empieza en cabeza).
            Nodo siguiente = null; // Nodo siguiente.

            while (actual != null) // Mientras haya nodos...
            {
                siguiente = actual.siguiente; // Guarda el siguiente nodo.
                actual.siguiente = anterior;  // Invierte la dirección.
                anterior = actual;            // Avanza el "anterior".
                actual = siguiente;           // Avanza el "actual".
            }
            cabeza = anterior;    // La nueva cabeza es el último nodo recorrido.
        }
    }

    class Ejercicio1
    {
        public void DemoInvertirLista()   // Método para probar la lista.
        {
            Console.WriteLine("Invertir lista de enteros ===");
            ListaEnlazada lista = new ListaEnlazada(); 
            lista.Agregar(1);                          
            lista.Agregar(2);                        
            lista.Agregar(3);                         
            lista.Agregar(4);                         

            Console.WriteLine("Lista original:");
            lista.Mostrar();                           // Muestra lista normal.

            lista.Invertir();                          // Invierte la lista.
            Console.WriteLine("Lista invertida:");
            lista.Mostrar();                           // Muestra lista invertida.
        }
    }
}
