using System;

public class Program
{
    //Definición del objeto delegado
    delegate void objDelegado();
    delegate void objSegundoDelegado(string mensaje);

    private static void Main(string[] args)
    {
        //Creación de objeto delegado referenciando a la tarea a realizar
        objDelegado elDelegado = new objDelegado(Bienvenida.SaludoBienvenida);

        //Ejecución de tarea a través del delegado
        elDelegado();

        elDelegado = new objDelegado(Despedida.MensajeDespedida);
        elDelegado();

        //Creación de objeto delegado referenciando a la tarea a realizar
        objSegundoDelegado elSegundoDelegado = new objSegundoDelegado(Bienvenida.SaludoBienvenida);

        //Ejecución de tarea a través del delegado con envío de parámetros
        elSegundoDelegado("Hola, ya llegué!");

        elSegundoDelegado = new objSegundoDelegado(Despedida.MensajeDespedida);

        elSegundoDelegado("Adios! Ya me voy");
    }
}

public class Bienvenida
{
    public static void SaludoBienvenida()
    {
        Console.WriteLine("Hola,acabo de llegar. ¿Qué tal?");
    }

    public static void SaludoBienvenida(string mensaje)
    {
        Console.WriteLine($"Mensaje de bienvenida: {mensaje}");
    }
}

public class Despedida
{
    public static void MensajeDespedida()
    {
        Console.WriteLine("Hola, ya me marcho. Hasta luego!");
    }

    public static void MensajeDespedida(string mensaje)
    {
        Console.WriteLine($"Mensaje de despedida: {mensaje}");
    }
}