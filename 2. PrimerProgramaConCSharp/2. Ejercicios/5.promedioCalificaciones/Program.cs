namespace _5.promedioCalificaciones;
class Program
{
    static void Main(string[] args)
    {
        float nota1, nota2, nota3,promedio;
        Console.WriteLine("Ingrese la nota del primer examen: ");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del segundo examen: ");
        nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del tercer examen: ");
        nota3 = float.Parse(Console.ReadLine());
        promedio = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("El promedio es: " + promedio);
    }
}
