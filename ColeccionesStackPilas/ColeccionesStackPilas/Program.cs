public class Program
{
    private static void Main(string[] args)
    {
        Stack<int> numeros = new Stack<int>();

        foreach (int num in new int[] {2,4,6,8,10})
        {
            //El último elemento agregado a la pila se encuentra al inicio.
            //El primer elemento agregado a la pila se encuentra al final.
            numeros.Push(num);
        }

        numeros.Pop(); //Se elimina el último elemento que se haya agregado a la pila

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}