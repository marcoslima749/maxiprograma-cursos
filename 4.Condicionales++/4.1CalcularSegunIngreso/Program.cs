namespace _4._1CalcularSegunIngreso;
class Program
{
    static void Main(string[] args)
    {

        /*
            1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
        */
        Console.WriteLine("Ingrese el primer numero");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("La resta de los dos números es: " + (a - b));
        }
        if (a == b)
        {
            Console.WriteLine("La suma de los dos números es: " + (a + b));
        }
        if (a < b)
        {
            Console.WriteLine("El producto de los dos números es: " + (a * b));
        }
        
    }
}
