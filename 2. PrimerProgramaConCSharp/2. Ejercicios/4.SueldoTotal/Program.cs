namespace _4.SueldoTotal;
class Program
{
    static void Main(string[] args)
    {
        float totalFacturado, comision, totalSueldo;
        Console.WriteLine("Ingrese el total facturado por el empleado");
        totalFacturado = float.Parse(Console.ReadLine());
        totalSueldo = 15000 + (totalFacturado * 5 / 100);
        Console.WriteLine("El total a cobrar es: " + totalSueldo.ToString("0.00"));
    }
}
