internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el valor del radio del circulo: ");

        double radio = double.Parse(Console.ReadLine());

        Console.WriteLine($"El circulo tiene un radio de {radio} unidades.");
        Console.WriteLine($"El circulo tiene un área de {Math.PI * Math.Pow(radio, 2)} unidades cuadradas.");
    }
}