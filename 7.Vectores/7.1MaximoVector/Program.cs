namespace _7._1MaximoVector;
class Program
{
    static void Main(string[] args)
    {

        // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo
        //y su posición dentro del vector.

        int[] numeros = new int[10];
        int maximo;
        int posicion = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un número: ");
            numeros[i] = int.Parse(Console.ReadLine());

        }
        maximo = numeros[0];
        
        for (int i = 0; i < 10; i++)
        {
            if(numeros[i] > maximo) {
                maximo = numeros[i];
                posicion = i + 1;
            }
            
        }

        Console.WriteLine("El máximo de los números ingresados es: " + maximo + " en la posición: " + posicion);

    }
}
