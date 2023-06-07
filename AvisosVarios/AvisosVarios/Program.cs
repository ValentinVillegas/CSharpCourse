using AvisosVarios;

internal class Program
{
    private static void Main(string[] args)
    {
        AvisosTrafico avisoUno = new AvisosTrafico();
        avisoUno.MostrarAviso();

        Console.WriteLine("\n\n\n");

        AvisosTrafico avisoDos = new AvisosTrafico("30/05/2023", "SAT - Servicio de Administración Tributaria", "Recuerda tramitar tu RFC para poder generar tus comprobantes de gastos");
        avisoDos.MostrarAviso();
    }
}