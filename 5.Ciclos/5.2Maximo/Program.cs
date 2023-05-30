namespace _5._2Maximo;
class Program
{
    static void Main(string[] args)
    {
        /*

        2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
        
        */

        int maximo = 0;
        int c = 0;

        while (c < 10)
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            if(c == 0 || numero > maximo) {
                maximo = numero;
            }

            c++;
        }

        Console.WriteLine("El número máximo de los ingresados es: "  + maximo);


    }
}
