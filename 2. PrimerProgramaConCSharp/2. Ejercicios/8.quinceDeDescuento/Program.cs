namespace _8.quinceDeDescuento;
class Program
{
    static void Main(string[] args)
    {
        float totalCompra;
        Console.WriteLine("Ingrese el total de la compra: ");
        totalCompra = float.Parse(Console.ReadLine());

        Console.WriteLine("El total a pagar es: " + (totalCompra * 0.85));
    }
}
