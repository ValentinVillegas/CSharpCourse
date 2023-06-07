using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = SolicitarNumeros();

        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }

        /*
        //int[] edades; //Declaración del Array
        //edades = new int[4]; //Inicialización del Array
        int[] edades = { 15, 27, 19, 80 }; //Declaración e inicialización en una sola línea
        edades[0] = 15; //Asignación al elementon con la posición 0 del Array
        edades[1] = 27;
        edades[2] = 19;
        edades[3] = 80;

        Console.WriteLine(edades[2]);

        var arrEmpleados = new[]
        {
            new {Nombre = "Juan", Edad=23},
            new {Nombre = "María", Edad=28},
            new {Nombre = "Ana", Edad=26}
        };

        Console.WriteLine(arrEmpleados[2].Nombre);

        Empleado empleadoAna = new Empleado("Ana", 26);

        Empleado[] empleados = new Empleado[3];
        empleados[0] = new Empleado("Juan", 23);
        empleados[1] = new Empleado("María", 28);
        empleados[2] = empleadoAna;

        Console.WriteLine(empleados[1].getNombre());
        */
    }

    static int[] SolicitarNumeros()
    {
        Console.Write("¿Cuantos elementos desea ingresar al array?: ");
        int cantElementos = int.Parse(Console.ReadLine());
        int[] numeros = new int[cantElementos];

        for (int i=0; i<cantElementos; i++)
        {
            Console.Write($"\nIngrese el valor que se guardará en la posición {i}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        return numeros;
    }
}

class Empleado
{
    string nombre;
    int edad;

    public Empleado(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public string getNombre() => nombre;
}