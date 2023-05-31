namespace _5._3PositivosInfinitos;
class Program
{
    static void Main(string[] args)
    {
        /*
        
        3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
        El fin de la carga se notifica con un número negativo.
        Luego mostrar cuántos números tiene cada lista.
        
        */

        //Comienza el programa, finaliza si se ingresa un negativo.
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        string informe = "";
        int numeroLista = 1;
        while(numero >=0) {
            //inicializa la cantidad de números de cada lista
            int cantNumeros = 0;
            //Ingresa si el número no es 0
            while(numero > 0) {
                cantNumeros++;
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
            }
            //Si se ingresó un cero se informa el número de lista en la variable informe y se incrementa el número de lista
            informe += "La lista " + numeroLista + " contiene " + cantNumeros + " número/s.\n";
            numeroLista++;

            //Si se ingresa un número negativo acá te vuelve a pedir, por eso hay que evitar que lo haga
            if(numero >= 0) {
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            }
        }

        //Al finalizar imprime cuántos números tiene cada lista de las ingresadas.
        if(informe == "") {
            Console.WriteLine("Finalizado el programa sin ingresan números positivos.");
        } else {
            Console.WriteLine(informe);
        }

    }
}
