using System;                     

namespace semana06               
{
    class Vehiculo                 // Clase que representa un vehículo.
    {
        public string placa;       // Placa del vehículo.
        public string marca;       // Marca del vehículo.
        public string modelo;      // Modelo del vehículo.
        public int anio;           // Año del vehículo.
        public double precio;      // Precio del vehículo.
        public Vehiculo siguiente; // Referencia al siguiente vehículo.

        public Vehiculo(string placa, string marca, string modelo, int anio, double precio)
        {
            this.placa = placa;    
            this.marca = marca;   
            this.modelo = modelo;  
            this.anio = anio;     
            this.precio = precio;  
            this.siguiente = null; 
        }
    }

    class ListaVehiculos           // Clase que maneja la lista de vehículos.
    {
        public Vehiculo cabeza;    // Primer vehículo de la lista.

        public void Agregar(string placa, string marca, string modelo, int anio, double precio)
        {
            Vehiculo nuevo = new Vehiculo(placa, marca, modelo, anio, precio); // Crea vehículo.
            if (cabeza == null)    // Si la lista está vacía...
                cabeza = nuevo;    // El nuevo es la cabeza.
            else
            {
                Vehiculo temp = cabeza;   // Recorre la lista.
                while (temp.siguiente != null) // Avanza hasta el último.
                    temp = temp.siguiente;
                temp.siguiente = nuevo;   // Conecta el nuevo al final.
            }
        }

        public void BuscarPorPlaca(string placa) // Busca vehículo por placa.
        {
            Vehiculo temp = cabeza;       // Empieza desde la cabeza.
            while (temp != null)          // Mientras haya vehículos...
            {
                if (temp.placa == placa)  // Si coincide la placa...
                {
                    Console.WriteLine($"Encontrado: {temp.placa}, {temp.marca}, {temp.modelo}, {temp.anio}, ${temp.precio}");
                    return;               // Termina la búsqueda.
                }
                temp = temp.siguiente;    // Avanza al siguiente.
            }
            Console.WriteLine("Vehículo no encontrado."); // Si no lo halló.
        }

        public void VerPorAnio(int anio)  // Muestra vehículos de un año.
        {
            Vehiculo temp = cabeza;
            while (temp != null)
            {
                if (temp.anio == anio)    // Si coincide el año...
                    Console.WriteLine($"{temp.placa}, {temp.marca}, {temp.modelo}, {temp.anio}, ${temp.precio}");
                temp = temp.siguiente;
            }
        }

        public void VerTodos()            // Muestra todos los vehículos.
        {
            Vehiculo temp = cabeza;
            while (temp != null)
            {
                Console.WriteLine($"{temp.placa}, {temp.marca}, {temp.modelo}, {temp.anio}, ${temp.precio}");
                temp = temp.siguiente;
            }
        }

        public void Eliminar(string placa) // Elimina vehículo por placa.
        {
            if (cabeza == null) return;   

            if (cabeza.placa == placa)   
            {
                cabeza = cabeza.siguiente; 
                Console.WriteLine("Vehículo eliminado.");
                return;
            }

            Vehiculo temp = cabeza;
            while (temp.siguiente != null) // Recorre lista.
            {
                if (temp.siguiente.placa == placa) 
                {
                    temp.siguiente = temp.siguiente.siguiente;
                    Console.WriteLine("Vehículo eliminado.");
                    return;
                }
                temp = temp.siguiente;
            }
            Console.WriteLine("Vehículo no encontrado."); // Si no lo halló.
        }
    }

    class Ejercicio2
    {
        public void DemoRegistroVehiculos() // Método  para probar lista.
        {
            Console.WriteLine("=== Ejercicio 2: Registro de vehículos ===");
            ListaVehiculos registro = new ListaVehiculos(); // Crea lista vacía.

            registro.Agregar("ABC123", "Toyota", "Corolla", 2020, 15000); // Agrega vehículo.
            registro.Agregar("XYZ789", "Honda", "Civic", 2021,