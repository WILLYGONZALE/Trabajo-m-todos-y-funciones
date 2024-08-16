// See https://aka.ms/new-console-template for more information
using System;

// Clase abstracta Figura
public abstract class Figura
{
    // Método abstracto para calcular el área
    public abstract double CalcularArea();
}

// Clase Circulo que hereda de Figura
public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    // Implementación del método abstracto
    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio; // Área de un círculo: π * r^2
    }
}

// Clase Rectangulo que hereda de Figura
public class Rectangulo : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    // Implementación del método abstracto
    public override double CalcularArea()
    {
        return Ancho * Alto; // Área de un rectángulo: ancho * alto
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de Circulo
        Figura circulo = new Circulo(5); // Radio = 5
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");

        // Crear una instancia de Rectangulo
        Figura rectangulo = new Rectangulo(4, 6); // Ancho = 4, Alto = 6
        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
    }
}
