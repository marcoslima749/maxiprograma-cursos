namespace _4._2DescuentoSegunLitros;
class Program
{
    static void Main(string[] args)
    {

        /*
            2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

        */
        Console.WriteLine("Ingrese el total de la venta:");
        float totalVenta = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de litros:");
        int cantidadLitros  = int.Parse(Console.ReadLine());

        if(cantidadLitros > 500) {
            totalVenta = totalVenta * 0.75F;
        } else if (cantidadLitros > 300) {
            totalVenta = totalVenta * 0.85F;
        } else if (cantidadLitros > 100) {
            totalVenta = totalVenta * 0.90F;
        }

        Console.WriteLine("El total a pagar es: " + totalVenta);

    }
}
