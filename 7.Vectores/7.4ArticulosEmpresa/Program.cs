namespace _7._4ArticulosEmpresa;
class Program
{
    static void Main(string[] args)
    {

        /*
        
        4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        - Número de Artículo (1 a 15)
        - Cantidad Vendida 

        Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        Se pide determinar e informar:
        a) El número de artículo que más se vendió en total.
        b) Los números de artículos que no registraron ventas.
        c) Cuantas unidades se vendieron del número de artículo 10.
        
        */

        int[] ventas = new int[15]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        Console.WriteLine("Ingrese el número de artículo");
        int articulo = int.Parse(Console.ReadLine());
        int maximoVentas = 0;
        int masVendido = 0;

        while (articulo > 0 && articulo <= 15) 
        {
            Console.WriteLine("Ingrese la cantidad vendida");
            int cantidad = int.Parse(Console.ReadLine());
            ventas[articulo - 1] += cantidad;

            if(ventas[articulo - 1] > maximoVentas) {   
                maximoVentas = ventas[articulo - 1];
                masVendido = articulo - 1;
            };

            Console.WriteLine("Ingrese el número de artículo");
            articulo = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("El ingreso de registros ha terminado.\nEl artículo más vendido es el artículo número " + (masVendido + 1) + " con " + maximoVentas + " ventas." );
        Console.WriteLine("Los articulos que no se vendieron son:");
        for (int i = 0; i < 15; i++)
        {
            if(ventas[i] == 0) {
                Console.WriteLine(i + 1);
            }
        }

        Console.WriteLine("El artículo número 10 registró " + ventas[9] + " ventas.");

    }
}
