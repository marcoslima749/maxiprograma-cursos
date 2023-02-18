namespace _3._4minimo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        float n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        float n3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        float n4 = float.Parse(Console.ReadLine());

        if (n1 < n2)
        {
            if (n1 < n3)
            {
                if (n1 < n4)
                {
                    Console.WriteLine("El minimo es: " + n1);
                }
                else
                {
                    Console.WriteLine("El minimo es: " + n4);
                }
            }
            else if (n3 < n4)
            {
                Console.WriteLine("El minimo es: " + n3);
            }
            else
            {
                Console.WriteLine("El minimo es: " + n4);
            }
        }
        else if (n2 < n3)
        {
            if (n2 < n4)
            {
                Console.WriteLine("El minimo es: " + n2);
            }
            else
            {
                Console.WriteLine("El minimo es: " + n4);
            }
        }
        else if (n3 < n4)
        {
            Console.WriteLine("El minimo es: " + n3);
        }
        else
        {
            Console.WriteLine("El minimo es: " + n4);
        }

    }
}
