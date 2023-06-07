public class Program
{
    private static void Main(string[] args)
    {
        Queue<int> numeros = new Queue<int>();

        foreach (int num in new int[] {2,4,6,8,10})
        {
            numeros.Enqueue(num);
        }

        numeros.Dequeue();//Se elimina el primer elemento de la cola

        //Recorriendo la cola
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}