namespace calculadora;
class Program
{
    static void Main(string[] args)
    {
        // paso 0
        // tipo de dato: int, float, char, bool
        int n1, n2, resultado;
        
        // paso 1: pedir los datos.
        Console.WriteLine("Ingrese un número:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número:");
        n2 = int.Parse(Console.ReadLine());

        // paso 2: realizar el cálculo.
        resultado = n1 + n2;
        // paso 3: mostrar el resultado.
        Console.WriteLine("El resultado es: " + resultado);
    }

}
