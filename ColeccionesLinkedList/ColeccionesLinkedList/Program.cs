public class Program
{
    private static void Main(string[] args)
    {
        LinkedList<int> listaNumeros = new LinkedList<int>();

        //Se agrega cada uno de los elementos del array a la LinkedList
        foreach (int num in new int[]{ 2,4,6,8,10})
        {
            listaNumeros.AddFirst(num);//Agrega un elemento al inicio de la lista
            //listaNumeros.AddLast(num);//Agrega un elemento al final de la lista
        }

        //Se crea un nuevo nodo y se agrega a la lista que ya tenía elementos
        LinkedListNode<int> nuevoElemento = new LinkedListNode<int>(18);
        listaNumeros.AddFirst(nuevoElemento);

        /*
        //Se recorre e imprime la lista de números
        foreach (int num in listaNumeros)
        {
            Console.WriteLine(num);
        }
        */

        //Se obtiene el primero nodo de la lista y se van recorriendo 1 a uno los nodos, si no hay más nodos por recorrer, retorna null
        for (LinkedListNode<int> numero = listaNumeros.First; numero != null; numero = numero.Next)
        {
            Console.WriteLine(numero.Value);
        }
    }
}