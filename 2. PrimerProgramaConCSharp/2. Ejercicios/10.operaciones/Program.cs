namespace _10.operaciones;
class Program
{
    static void Main(string[] args)
    {
        float num1, num2;
        Console.WriteLine("Ingrese el primer número: ");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        num2 = float.Parse(Console.ReadLine());

        Console.WriteLine(num1);

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2).ToString("0.00"));
        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2).ToString("0.00"));

    }
}
