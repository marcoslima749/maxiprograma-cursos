namespace _4._5EstanOrdenados;
class Program
{
    static void Main(string[] args)
    {
        /*
        
        5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
        
        */
        Console.WriteLine("Ingrese un número");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el último número");
        int d = int.Parse(Console.ReadLine());

        if(a>b && b>c && c>d) {
            Console.WriteLine("Los números están en orden decreciente");
        } else {
            Console.WriteLine("Los números NO están en orden decreciente");
        }

    }
}
