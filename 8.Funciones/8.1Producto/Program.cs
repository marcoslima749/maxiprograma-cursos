namespace _8._1Producto;
class Program
{
    static void Main(string[] args)
    {
        
        // 1. Hacer una función llamada “producto” que reciba dos números enteros
        // y que devuelva el producto de ambos. Luego hacer un programa que pida el precio
        // de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar.
        // Usar la función.

        Console.WriteLine("Ingrese el precio del articulo: ");
        int precio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida:");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("El total a pagar es : " + producto(precio,cantidad));


    }

    static int producto (int a, int b) {
        return a * b;
    }
}
