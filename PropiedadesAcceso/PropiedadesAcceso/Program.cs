using PropiedadesAcceso;

internal class Program
{
    private static void Main(string[] args)
    {
        Empleado emp1 = new Empleado("Juan", 1200);
        emp1.SALARIO = -3500;

        Console.WriteLine($"El salario del empleado es: ${emp1.SALARIO}");
    }
}