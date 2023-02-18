namespace _3._2positivoNegativo;
class Program
{
    static void Main(string[] args)
    {
        float numero;
        Console.WriteLine("Ingrese un número:");
        numero = float.Parse(Console.ReadLine());
        if(numero > 0) {
            Console.WriteLine("Positivo!");
        } else if(numero == 0) {
            Console.WriteLine("Cero");
        } else {
            Console.WriteLine("Negativo...");
        }
    }
}
