using System;

// Clase Rectangulo que hereda de FiguraGeometrica
public class Rectangulo : FiguraGeometrica
{
    private double baseRectangulo;
    private double altura;

    public Rectangulo(double baseRectangulo, double altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    // Implementación del cálculo del área
    public override double CalcularArea()
    {
        return baseRectangulo * altura;
    }

    // Implementación del cálculo del perímetro
    public override double CalcularPerimetro()
    {
        return 2 * (baseRectangulo + altura);
    }
}