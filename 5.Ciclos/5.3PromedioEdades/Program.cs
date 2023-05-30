namespace _5._3PromedioEdades;
class Program
{
    static void Main(string[] args)
    {
        /*
        
        3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
        
        */

        int c = 0;
        int sumaMayores = 0;
        int cantidadMayores = 0;
        int promedio = 0;

        while (c < 20)
        {
            Console.WriteLine("Ingrese una edad");
            int edad = int.Parse(Console.ReadLine());
            if(edad > 18) { //La consigna pide mayor a 18 años por eso no incluí a las personas de 18 años.
                sumaMayores += edad;
                cantidadMayores++;
            }
            c++;
        }

        promedio = sumaMayores / cantidadMayores; //aparentemente al ser de tipo int la parte decimal del número se trunca. Yo pensé que iba a tirar error.

        Console.WriteLine("El promedio de edades superiores a 18 es: " + promedio);


    }
}
