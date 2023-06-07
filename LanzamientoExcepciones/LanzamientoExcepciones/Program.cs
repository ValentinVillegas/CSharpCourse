internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa un número de mes: ");
        int mesIngresado = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine($"El nombre para el mes ingresado es: {nombreDelMes(mesIngresado)}");
        }catch(Exception ex)
        {
            Console.WriteLine($"Mensaje de la excepción producida: {ex.Message}");
        }

        Console.WriteLine("Aquí continuaría la ejecución del programa");
    }

    public static string nombreDelMes(int mes)
    {
        switch (mes)
        {
            case 1:
                return "Enero";

            case 2:
                return "Febrero";

            case 3:
                return "Marzo";

            case 4:
                return "Abril";

            case 5:
                return "Mayo";

            case 6:
                return "Junio";

            case 7:
                return "Julio";

            case 8:
                return "Agosto";
            
            case 9:
                return "Septiembre";

            case 10:
                return "Octubre";

            case 11:
                return "Noviembre";

            case 12:
                return "Diciembre";

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}