// See https://aka.ms/new-console-template for more information
public interface ILavadora
{
    void Centrifugar();
    void Lavar();
    void Enjuagar();
    void Remojar();
}
public abstract class LavadoraBase : ILavadora
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }

    public LavadoraBase(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public virtual void Centrifugar()
    {
        Console.WriteLine("La lavadora esta Centrifungando.");
    }

    public virtual void Lavar()
    {
        Console.WriteLine("La lavadora esta lavando.");
    }

    public virtual void Enjuagar()
    {
        Console.WriteLine("La lavadora esta enjugando.");
    }

    public virtual void Remojar()
    {
        Console.WriteLine("La lavadora esta remojando.");
    }
}
public class Lavadora : LavadoraBase
{
    public int Tamaño { get; set; }

    public Lavadora(string marca, string modelo, int año, int Tamaño)
        : base(marca, modelo, año)
    {
        Tamaño = Tamaño;
    }

    // Métodos específicos para La Lavadora
    public override void Centrifugar()
    {
        Console.WriteLine("La lavadora esta centrifugando");
    }

}
public class Lavadora_Secadora : LavadoraBase
{
    public string TipoLavado{ get; set; }

    public Lavadora_Secadora(string marca, string modelo, int año, string tipolavado)
        : base(marca, modelo, año)
    {
        TipoLavado = tipolavado;
    }

    // Métodos específicos para la lavadora secadora
    public override void Centrifugar()
    {
        Console.WriteLine("La lavadora esta secando.");
    }


}
class Program
{
    static void Main(string[] args)
    {
        ILavadora milavadora = new Lavadora("Samsung", "Inox", 2021, 4);
        milavadora.Centrifugar();
        milavadora.Lavar();
        milavadora.Enjuagar();
        milavadora.Remojar();

        ILavadora milavadora_Secadora = new Lavadora_Secadora("Kalley", "K.ls14", 2022, "cara");
        milavadora_Secadora.Centrifugar();
        milavadora_Secadora.Lavar();
        milavadora_Secadora.Enjuagar();
        milavadora_Secadora.Remojar();
    }
}