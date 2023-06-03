namespace _7._2PromedioVector;
class Program
{
    static void Main(string[] args)
    {
        // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
        // Luego recorrer ese vector para calcular el promedio.
        // Mostrar por pantalla los valores que son mayores al promedio.
        
        int[] numeros = new int[10];
        int acumulado = 0;
        int promedio;

        for (int i = 0; i < 10; i++)
        {
            
            Console.WriteLine("Ingrese un número:");
            numeros[i] = int.Parse(Console.ReadLine());
            acumulado+= numeros[i];
           
        }

        promedio = acumulado / 10;

        Console.WriteLine("Los valores mayores al promedio son:");

        for (int i = 0; i < 10; i++)
        {
            if(numeros[i] > promedio) {
                Console.WriteLine(numeros[i]);
            }
        }


    }
}
