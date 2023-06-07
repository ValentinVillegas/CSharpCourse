internal class Program
{
    private static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int numeroAleatorio = aleatorio.Next(0, 101);

        int numeroIngresado = -1;
        int intentosRealizados = 0;
        bool numeroValido = false;

        Console.Write("Ingrese un número entre 0 y 100: ");

        do
        {
            while (!numeroValido)
            {
                try
                {
                    numeroIngresado = int.Parse(Console.ReadLine());
                    if (numeroIngresado < numeroAleatorio) Console.Write("Ingresa un número más alto: ");
                    if (numeroIngresado > numeroAleatorio) Console.Write("Ingresa un número más bajo: ");
                    numeroValido = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El número ingresado no es un número válido");
                    Console.Write("Ingresa un número: ");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("El número intriducido es demasiado alto.");
                    Console.Write("Ingresa un número: ");
                }
            }

            intentosRealizados++;
            numeroValido = false;
        } while (numeroIngresado != numeroAleatorio);

        Console.WriteLine($"\n!Haz acertado el número aleatorio en {intentosRealizados} intentos¡.");
    }
}