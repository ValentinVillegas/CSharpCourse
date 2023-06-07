using Predicados;

public class Program
{
    static bool seLlamaJuan (Persona p)
    {
        return p.Nombre.Contains("Juan");
    }

    private static void Main(string[] args)
    {
        List<Persona> personas = new List<Persona>();

        personas.AddRange(new Persona[]
        {
            new Persona(){Nombre = "Juan Esparza", Edad=18},
            new Persona(){Nombre = "Maria", Edad=28},
            new Persona(){Nombre = "Ana", Edad=37},
            new Persona(){Nombre = "Juan Noriega", Edad=38}
        });

        Predicate<Persona> buscarPersonaByNombre = new Predicate<Persona>(seLlamaJuan);

        List<Persona> filtroPersonas = personas.FindAll(buscarPersonaByNombre);

        foreach(Persona p in filtroPersonas)
        {
            Console.WriteLine($"Nombre completo: {p.Nombre} \tEdad: {p.Edad}");
        }
    }
}