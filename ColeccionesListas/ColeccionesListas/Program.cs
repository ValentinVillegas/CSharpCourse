using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese un número para agregar a la lista o 0 para imprimir la lista\n");

        int nuevoNum = -1;

        while (nuevoNum != 0)
        {
            Console.Write("Agregar número: ");
            nuevoNum = int.Parse(Console.ReadLine());
            numeros.Add(nuevoNum);
        }

        numeros.RemoveAt(numeros.Count-1);
        Console.WriteLine("Los elementos de la lista son:");

        foreach(int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}