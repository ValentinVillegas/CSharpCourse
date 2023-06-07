public class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int aleatorio;
        List<int> numeros = new List<int>();
        string listaNumeros = "";
        List<int> listaPares = new List<int>();

        for (int i = 0; i<=9; i++)
        {
            aleatorio = random.Next(0, 101);
            numeros.Add(aleatorio);
        }

        numeros.ForEach(n => listaNumeros += n + ", ");
        Console.WriteLine($"La lista de números generados aleeatoriamente es la siguiente: {listaNumeros}");

        listaNumeros = "";
        listaPares = numeros.FindAll(n => n%2 == 0);
        listaPares.ForEach(n => listaNumeros += n + ", ");
        Console.WriteLine($"Los números pares en la lista son los siguientes: {listaNumeros}");
    }
}