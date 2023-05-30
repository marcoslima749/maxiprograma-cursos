namespace _4._3CompraPC;
class Program
{
    static void Main(string[] args)
    {

        /*
        
        3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

        i5 (1)	i7 (2)	i9 (3)
        8 RAM (1)	USD 800	USD 900	USD 1200
        16 RAM (2)	USD 900	USD 1000	USD 1400
        32 RAM (3)	USD 1000	USD 1400	USD 2000
        Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
                
        */

        Console.WriteLine("Ingrese el número de opción para procesador: 1) i5  2) i7  3) i9");
        int procesador = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de opción para memoria RAM: 1) 8GB  2) 16GB  3) 32GB");
        int ram = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Desea expandir el almacenamiento de 500GB a 1TB? 0) No 1) Sí ");
        int expande = int.Parse(Console.ReadLine());

        int precioFinal = 0;

        switch (procesador)
        {
            case 1:
                switch (ram)
                {
                    case 1:
                        precioFinal = 800;
                    break;
                    case 2:
                        precioFinal = 900;
                    break;
                    case 3:
                        precioFinal = 1000;
                    break;
                }
                break;
            case 2:
                switch (ram)
                {
                    case 1:
                    precioFinal = 900;
                    break;
                    case 2:
                    precioFinal = 1000;
                    break;
                    case 3:
                    precioFinal = 1400;
                    break;
                }
                break;
            case 3:
                switch (ram)
                {
                    case 1:
                    precioFinal = 1200;
                    break;
                    case 2:
                    precioFinal = 1400;
                    break;
                    case 3:
                    precioFinal = 2000;
                    break;
                }
                break;
        }

        if(expande == 1) {
            precioFinal += 300;
        }

        Console.WriteLine("El precio de la PC que ha elegido es: " + precioFinal);

    }
}
