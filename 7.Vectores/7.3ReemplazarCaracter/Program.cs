namespace _7._3ReemplazarCaracter;
class Program
{
    static void Main(string[] args)
    {

        // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
        // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado
        //hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
        // CADENA FUENTE: “La mar estaba serena"
        // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        // CADENA RESULTADO: “Li mir estibi sereni"


        string cadena;
                char caracterUno, caracterDos;
    
        Console.WriteLine("Ingrese una cadena de carácteres para modificar: ");

        cadena = Console.ReadLine();

        Console.WriteLine("Ingrese el caracter a reemplazar: ");
        caracterUno = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nuevo caracter: ");
        caracterDos = char.Parse(Console.ReadLine());


        int indice = 0;
        char[] cadenaReemplazada = new char[cadena.Length + 1];

        while(indice < cadena.Length) {
            if(cadena[indice] == caracterUno) {
                cadenaReemplazada[indice] = caracterDos;
            } else {
                cadenaReemplazada[indice] = cadena[indice];
            }
            indice++;
        }

        Console.WriteLine("La cadena de carácteres modificada es:");
        Console.WriteLine(cadenaReemplazada);


    }
}
