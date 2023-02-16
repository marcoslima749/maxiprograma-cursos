namespace _2cubo_de_un_numero;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca un número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("El cubo de " + n1 + " es: " + (n1*n1*n1));
    }
}
