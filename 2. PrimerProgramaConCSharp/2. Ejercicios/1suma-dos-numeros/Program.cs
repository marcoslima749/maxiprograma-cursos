namespace _1suma_dos_numeros;
class Program
{
    static void Main(string[] args)
    {
        int n1, n2;
        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("El resultado es: " + (n1 + n2));
        
    }
}
