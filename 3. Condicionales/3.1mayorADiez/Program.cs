namespace _3._1mayorADiez;
class Program
{
    static void Main(string[] args)
    {
        float numero;
        Console.WriteLine("Ingrese un número:");
        numero = float.Parse(Console.ReadLine());
        if(numero > 10) {
            Console.WriteLine("El numero es mayor a 10!");
        } else if(numero == 10) {
            Console.WriteLine("El número es igual a 10...");
        } else {
            Console.WriteLine("El número es menor a 10...");
        }
    }
}
