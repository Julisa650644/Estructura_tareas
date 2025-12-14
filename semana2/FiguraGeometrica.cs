using System;

// Clase abstracta que sirve como base para todas las figuras
public abstract class FiguraGeometrica
{
    // Método abstracto para calcular el área
    public abstract double CalcularArea();

    // Método abstracto para calcular el perímetro
    public abstract double CalcularPerimetro();

    // Método común para mostrar resultados
    public void MostrarResultados()
    {
        Console.WriteLine("Área: " + CalcularArea());
        Console.WriteLine("Perímetro: " + CalcularPerimetro());
    }
}