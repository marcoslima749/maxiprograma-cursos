namespace _8._3LotePrimos;
class Program
{
    static void Main(string[] args)
    {

        // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1
        // si el número es primo o cero si no lo es. Hacer un programa para ingresar números.
        // El lote corta cuando se ingresa un número cero.
        // Informar el promedio teniendo en cuenta sólo los números primos.

        int acumulado = 0;
        int contador = 0;

        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());

        while(numero > 0) {

            if(primo(numero) == 1) {
                acumulado += numero;
                contador++;
            }

        Console.WriteLine("Ingrese un número:");
        numero = int.Parse(Console.ReadLine());

        }

        int promedio = acumulado / contador;

        Console.WriteLine("El promedio de los números ingresados que son primos es: " + promedio);


    }

    static int primo (int num) {
        int divisores = 0;
        for (int i = 1; i <= num; i++)
        {
            if(num % i == 0) {
                divisores++;
            }
        }
        if(divisores == 2) {
            return 1;
        } else {
            return 0;
        }
    }
}
