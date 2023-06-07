using Herencia;
using Herencia.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        Caballo babieca = new Caballo("Babieca");
        Humano juan = new Humano("Juan");
        Gorila copito = new Gorila("Copito");
        Lagartija juancho = new Lagartija("Juancho");

        juan.Respirar();
        juan.GetNombre();        
        babieca.GetNombre();
        /*
        IMamiferosTerrestres caballo = babieca;
        Console.WriteLine($"Número de patas: {caballo.NumeroPatas()}");
        */
        ISaltoConPatas caballo = babieca;
        Console.WriteLine($"Patas utilizadas en el salto de un caballo: {caballo.NumeroPatas()}");
        copito.GetNombre();


        juancho.Respirar();
        juancho.GetNombre();
    }
}