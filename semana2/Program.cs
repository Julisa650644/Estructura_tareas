using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo con radio 5
        FiguraGeometrica c = new Circulo(5);
        Console.WriteLine("Círculo:");
        c.MostrarResultados();

        // Crear un rectángulo con base 10 y altura 4
        FiguraGeometrica r = new Rectangulo(10, 4);
        Console.WriteLine("\nRectángulo:");
        r.MostrarResultados();
    }  //fin
}
