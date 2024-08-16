// See https://aka.ms/new-console-template for more information
using System;

public class Producto
{
    private decimal precio;

    // Precio con get y set
    public decimal Precio
    {
        get
        {
            return precio;
        }
        set
        {
            // el precio no puede ser negativo
            if (value < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
            }
            else
            {
                precio = value;
            }
        }
    }

    public Producto(decimal precioInicial)
    {
        Precio = precioInicial;
    }
}

class Program
{
    static void Main()
    {
        // precio inicial válido
        Producto producto = new Producto(100m);

        // precio actual
        Console.WriteLine($"Precio del producto: {producto.Precio}");

        // Intentamos establecer un precio negativo
        producto.Precio = -50;

        // el precio después de intentar asignar un valor negativo
        Console.WriteLine($"Precio del producto: {producto.Precio}");

        //precio válido
        producto.Precio = 120m;

        // precio actualizado
        Console.WriteLine($"Precio del producto: {producto.Precio}");
    }
}

