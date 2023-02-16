namespace _3bis.calcular_edad;
class Program
{
    static void Main(string[] args)
    {
        int nacimiento, actualidad;
        Console.WriteLine("Ingresar año de nacimiento: ");
        nacimiento = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar año actual: ");
        actualidad = int.Parse(Console.ReadLine());

        Console.WriteLine("La edad actual es: " + (actualidad - nacimiento));

    }
}
