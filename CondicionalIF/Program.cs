internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA PARA DETERMINAR SI PUEDES CONDUCIR VEHICULOS");

        Console.Write("Ingresa tu edad: ");

        int edad = int.Parse(Console.ReadLine());
        bool tieneLicnencia = false;

        if(edad < 18)
        {
            Console.WriteLine("No puedes conducir vehículos");
        }
        else
        {
            Console.Write("¿Cuentas con licencia para conducir? 1:Si  2:No :");

            tieneLicnencia = int.Parse(Console.ReadLine()) == 1;

            if (!tieneLicnencia)
            {
                Console.WriteLine("No puedes conducir vehiculos");
            }
            else
            {
                Console.WriteLine("¡Adelante! Puedes conducir vehiculos");
            }
        }
    }
}