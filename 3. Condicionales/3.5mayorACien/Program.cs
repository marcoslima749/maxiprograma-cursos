namespace _3._5mayorACien;
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
        
        string mayoresACien = "";

        if(n1 > 100) {
            mayoresACien = mayoresACien + n1.ToString() + " ";
        }
        if(n2 > 100) {
            mayoresACien = mayoresACien + n2.ToString() + " ";
        }
        if(n3 > 100) {
            mayoresACien = mayoresACien + n3.ToString() + " ";
        }
        if(n4 > 100) {
            mayoresACien = mayoresACien + n4.ToString() + " ";
        }

        if(mayoresACien.Length >= 1) {
            Console.WriteLine("Los números ingresados mayores a 100 son: " + mayoresACien);
        } else {
            Console.WriteLine("No hay números mayores a 100!");
        }

    }
}
