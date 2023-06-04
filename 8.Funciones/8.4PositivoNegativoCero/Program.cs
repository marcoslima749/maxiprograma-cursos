namespace _8._4PositivoNegativoCero;
class Program
{
    static void Main(string[] args)
    {

        // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada
        // “positivoNegativoCero” que reciba un número por valor y una variable por referencia.
        // Que analice el número y escriba variable recibida por referencia con:

        // a. 1 si el número es positivo.
        // b. -1 si el número es negativo.
        // c. 0 si el número es cero.

        int signo = 0;

        Console.WriteLine("Ingrese un número");
        int numero = int.Parse(Console.ReadLine());

        positivoNegativoCero(numero, ref signo);

        Console.Write("El número ingresado es ");
        if(signo == 1) {
            Console.Write("positivo.");
        } else if(signo == 0) {
            Console.Write("cero.");
        } else {
            Console.Write("negativo.");
        }


    }

    static void positivoNegativoCero(int num, ref int resultado) {
        if(num > 0) {
            resultado = 1;
        } else if(num < 0) {
            resultado = -1;
        } else {
            resultado = 0;
        }
    }
}
