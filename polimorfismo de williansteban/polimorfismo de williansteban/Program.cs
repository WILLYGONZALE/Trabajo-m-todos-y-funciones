// See https://aka.ms/new-console-template for more information
using System;

namespace PolimorfismoYEncapsulamientowillian
{
    // Clase base
    public abstract class Animal
    {
        // Propiedad encapsulada
        private string nombre;

        // Constructor
        public Animal(string nombre)
        {
            this.nombre = nombre;
        }

        // Método protegido para obtener el nombre (encapsulamiento)
        protected string Nombre()
        {
            return nombre;
        }

        // Método abstracto que debe ser implementado por las clases derivadas (polimorfismo)
        public abstract void Ladrar();
    }

    // Clase derivada
    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }

        // método abstracto
        public override void Ladrar()
        {
            Console.WriteLine($"{Nombre()} dice: Guau");
        }
    }

    // Otra clase derivada
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        // método abstracto
        public override void Ladrar()
        {
            Console.WriteLine($"{Nombre()} dice: ¡Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creando instancias de Perro y Gato
            Animal miPerro = new Perro("Rex");
            Animal miGato = new Gato("Mittens");

            // Usando polimorfismo para hacer que cada animal haga sonido
            miPerro.Ladrar();
            miGato.Ladrar();
        }
    }
}
