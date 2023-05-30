namespace _5._4EsPrimo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        int esPrimo = 1;
        int contador = 2;

        while(contador < numero) {
            if(numero % contador == 0){
                esPrimo = 0;
            }
            contador++;
        }

        if(numero > 1 && esPrimo == 1) {
        Console.WriteLine("El número ingresado es primo");
        } else {
        Console.WriteLine("El número ingresado NO es primo");
        }

    }
}
