namespace TPFinal_Lima;
class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
        // A partir de dichos datos informar:

        //     a. El mayor de los números pares.
        //     b. La cantidad de números impares.
        //     c. El menor de los números primos.

        // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

        int maximoPares = 0;
        bool primerPar = true;

        int cantidadImpares = 0;

        int minimoPrimos = 0;
        bool primerPrimo = true;

        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());

        while(numero != 0) {

            //Si el número ingresado es par pregunta si es el primer ingreso o si es mayor al máximo
            //y en ese caso lo reemplaza
            //Si no es par incrementa la cantidad de impares
            if(esPar(numero)) {
                if(primerPar || numero > maximoPares) {
                    maximoPares = numero;
                    primerPar = false;
                }
            } else {
                cantidadImpares++;
            }


            //Además si es primo verifica si es menor al mínimo y lo reemplaza.
            if(esPrimo(numero)) {
                if(primerPrimo || numero < minimoPrimos) {
                    minimoPrimos = numero;
                    primerPrimo = false;
                }
            }


            //Luego vuelve a pedir un número hasta que se ingrese 0
            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());
        }


        //Finalizado el ingreso informa los resultados

        Console.WriteLine("El mayor de los números pares es: " + maximoPares);
        Console.WriteLine("La cantidad de números impares es:" + cantidadImpares);
        Console.WriteLine("El menor de los números primos es:" + minimoPrimos);

    }

    static bool esPrimo(int num) {
        int divisores = 0;
        for (int i = 1; i <= num; i++)
        {
            if(num % i == 0) {
                divisores++;
            }
        }
        return divisores == 2;
    }

    static bool esPar(int num) {
        return num % 2 == 0;
    }
}
