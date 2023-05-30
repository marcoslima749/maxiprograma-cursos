namespace _4._4ComparaTresNumeros;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /*
        
        4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        */
        Console.WriteLine("Ingrese el primer número");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número");
        int c = int.Parse(Console.ReadLine());

        if((a+b)>(b*c)) {
            Console.WriteLine("La suma de los dos primeros números es MAYOR al producto del segundo con el tercer número.");
        } else {
            Console.WriteLine("La suma de los dos primeros números es MENOR al producto del segundo con el tercer número.");
        }
    }
}
