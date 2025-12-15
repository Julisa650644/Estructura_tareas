using System;

class Program
{
    static void Main(string[] args)
    {
        Estudiante est = new Estudiante();

        Console.Write("ID: ");
        est.ID = int.Parse(Console.ReadLine());

        Console.Write("Nombres: ");
        est.Nombres = Console.ReadLine();

        Console.Write("Apellidos: ");
        est.Apellidos = Console.ReadLine();

        Console.Write("Dirección: ");
        est.Direccion = Console.ReadLine();

        Console.WriteLine("Ingrese los 3 teléfonos:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            est.Telefonos[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Datos Registrados ---");
        Console.WriteLine($"ID: {est.ID}");
        Console.WriteLine($"Nombres: {est.Nombres}");
        Console.WriteLine($"Apellidos: {est.Apellidos}");
        Console.WriteLine($"Dirección: {est.Direccion}");

        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"  {est.Telefonos[i]}");
        }
    }
}
