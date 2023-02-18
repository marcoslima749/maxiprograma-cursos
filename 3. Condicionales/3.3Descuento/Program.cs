namespace _3._3Descuento;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el importe total de la venta");
        float importe = float.Parse(Console.ReadLine());
        if(importe >= 5000) {
            Console.WriteLine("El importe a pagar es: " + (importe * 0.82));
        } else if (importe >= 1000) {
            Console.WriteLine("El importe a pagar es: " + (importe * 0.90));
        } else {
            Console.WriteLine("El importe a pagar es: " + importe);
        }
    }
}
