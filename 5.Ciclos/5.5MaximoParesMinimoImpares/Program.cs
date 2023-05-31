namespace _5._5MaximoParesMinimoImpares;
class Program
{
    static void Main(string[] args)
    {
        /*

        5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
        
        */

        int c = 0;
        int maximoPares = 0;
        int minimoImpares = 0;
        int pares = 0;
        int impares = 0;

        while (c<20)
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            if(numero % 2 == 0) {
                if(pares == 0 ||  numero > maximoPares) {
                    maximoPares = numero;
                    pares = 1;
                }
            } else {
                if(impares == 0 || numero < minimoImpares) {
                    minimoImpares = numero;
                    impares = 1;
                }
            }

            c++;
        }

        Console.WriteLine("El máximo de los pares es: " + maximoPares + " y el mínimo de los impares es: " + minimoImpares);

    }
}
