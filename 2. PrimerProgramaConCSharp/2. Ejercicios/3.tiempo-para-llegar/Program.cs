namespace _3.tiempo_para_llegar;
class Program
{
    static void Main(string[] args)
    {
        float distancia, velocidad, horasParaLlegar;
        Console.WriteLine("Ingrese la distancia a recorrer entre una ciudad y otra, en kilómetros: ");
        distancia = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la velocidad promedio a la que viajará, en kilómetros por hora: ");
        velocidad = float.Parse(Console.ReadLine());
        horasParaLlegar = distancia / velocidad;
        Console.WriteLine("El tiempo que demorará en llegar es: " + horasParaLlegar + " horas.");

    }
}
