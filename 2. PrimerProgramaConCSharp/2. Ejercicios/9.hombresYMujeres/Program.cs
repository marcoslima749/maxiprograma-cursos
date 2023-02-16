namespace _9.hombresYMujeres;
class Program
{
    static void Main(string[] args)
    {
        float qHombres, qMujeres;
        Console.WriteLine("Ingrese la cantidad de mujeres: ");
        qMujeres = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de hombres: ");
        qHombres = float.Parse(Console.ReadLine());

        Console.WriteLine("El porcentaje de mujeres es: " + (qMujeres / (qHombres + qMujeres) * 100).ToString("0.00") + " %");
        Console.WriteLine("El porcentaje de hombres es: " + (qHombres / (qHombres + qMujeres)).ToString("0.00 %"));

    }
}
