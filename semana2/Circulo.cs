using System;

// Clase Circulo que hereda de FiguraGeometrica
public class Circulo : FiguraGeometrica
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Implementación del cálculo del área
    public override double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Implementación del cálculo del perímetro
    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}