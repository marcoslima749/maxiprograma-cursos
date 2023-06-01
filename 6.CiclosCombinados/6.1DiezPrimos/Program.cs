namespace _5._1DiezPrimos;
class Program
{
    static void Main(string[] args)
    {
        /*
        
        1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
        
        */

        int primos = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;
            int divisores = 0;
            while(numero > 1 && contador <= numero) { 
                if(numero % contador == 0) {
                    divisores++;
                }
                contador++;
            }
            if(divisores == 2) {
                primos++;
            }

        }

        Console.WriteLine("La cantidad de números primos es: " + primos);
    }
}
