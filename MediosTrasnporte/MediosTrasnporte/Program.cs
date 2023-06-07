using MediosTrasnporte;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========= Probando el Avión =========");
        Avion miAvion = new Avion();
        miAvion.ArrancarMotor();
        miAvion.Despegar();
        miAvion.Conducir();
        miAvion.Aterrizar();

        Console.WriteLine("\n\n========= Probando el Coche =========");
        Coche miCoche = new Coche();
        miCoche.ArrancarMotor();
        miCoche.Acelerar();
        miCoche.Conducir();
        miCoche.Frenar();
        miCoche.DetenerMotor();

        Console.WriteLine("\n\n========= Polimorfismo en acción =========");
        MedioTrasnsporte vehiculo = miCoche;
        vehiculo.Conducir();
        vehiculo = miAvion;
        vehiculo.Conducir();
    }
}