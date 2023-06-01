namespace _5._2CincoGrupos;
class Program
{
    static void Main(string[] args)
    {
        /*
        
        2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

        El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        
        */

        //Inicializa las variables
        float maxPorcentajeImpares = -1F; //como el porcentaje va a estar entre 0 y 1, para la primera comparación messirve ponerlo en negativou
        int grupoMaxImpares = 1;
        int cantGruposOrdenados = 0;


        for (int grupo = 1; grupo <= 5; grupo++)
        {

            float cantImpares = 0F;
            float cantTotal = 0F;
            int contador = 0;
            int numAnterior = 0;
            bool ordenado = true;

            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                //Si el número es impar incrementa los impares
                if(numero % 2 != 0) {
                    cantImpares++;
                }
                //Siempre incrementa el total
                cantTotal++;

                //Si el contador es 0 (en la primera iteración siempre está ordenado) o el número es menor al anterior y además estaba previamente ordenado (de iteraciones anteriores) mantiene la variable ordenado en true, si no la establece en false
                ordenado = contador == 0 || numAnterior >= numero && ordenado == true;

                //Incrementa el contador
                contador++;

                //Reasigna el número anterior
                numAnterior = numero;

                //Pide otro valor para continuar (o no) el bucle
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());   
            };

            //Acá procesa la información de cada grupo:

            //Si es el mayor porcentaje (el primero siempre es mayor porque la variable está inicializada en negativo) lo reemplaza
            if(cantImpares / cantTotal > maxPorcentajeImpares) {
                maxPorcentajeImpares = cantImpares / cantTotal;
                grupoMaxImpares = grupo;
            }

            //Si está ordenado de mayor a menor incrementa la variable correspondiente
            if(ordenado == true) {
                cantGruposOrdenados++;
            }
            //Restablece la variable para el próximo grupo
            ordenado = true;

        }

        Console.WriteLine("El número de grupo con mayor porcentaje de números impares es el número: " + grupoMaxImpares + " (" + (maxPorcentajeImpares * 100) + "%)");
        Console.WriteLine(cantGruposOrdenados + " grupos están ordenados de mayor a menor");
    }
}
