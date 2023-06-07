public class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string,int> personas = new Dictionary<string,int>();

        personas.Add("Juan", 18);
        personas.Add("Javier", 24);
        personas["Fernanda"] = 32;
        personas["Oscar"] = 28;

        foreach (KeyValuePair<string,int> p in personas)
        {
            Console.WriteLine($"Nombre: {p.Key} \tEdad: {p.Value}");
        }
    }
}