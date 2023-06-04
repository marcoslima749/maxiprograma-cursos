namespace _8._2VeinteParImpar;
class Program
{
    static void Main(string[] args)
    {

        /*
        
        2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par
        o cero si no lo es. Hacer un programa para ingresar 20 números
        y mostrar por pantalla cuántos son pares.
        
        */
        int pares = 0;
        int impares = 0;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            if(esPar(numero) == 1) {
                pares++;
            } else {
                impares++;
            }
        }

        Console.WriteLine("La cantidad de números pares es: " + pares + " y la cantidad de impares es: " + impares + ".");

    }

static int esPar(int n) {
    if(n % 2 == 0) {
        return 1;
    }
    return 0;
}

}
