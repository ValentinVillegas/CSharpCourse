internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el valor del primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del tercer número: ");
        double numero3 = double.Parse(Console.ReadLine());

        //Llamada al método Suma con 2 parámetros
        Console.WriteLine($"La suma de {numero1} + {numero2} es de {Suma(numero1,numero2)}");

        //Llamada al método Suma con 2 parámetros de diferente tipo
        Console.WriteLine($"La suma de {numero1} + {numero3} es de {Suma(numero1, numero3)}");

        //Llamada al método Suma con 3 parámetros, 1 de ellos es opcional
        Console.WriteLine($"La suma de {numero1} + {numero2} es de {Suma(numero1, numero2)}");
    }

    private static int Suma(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    private static double Suma(int numero1, double numero2)
    {
        return numero1 + numero2;
    }

    private static double Suma(int numero1, int numero2, int numero3 = 0)
    {
        return numero1 + numero2 + numero3;
    }
}