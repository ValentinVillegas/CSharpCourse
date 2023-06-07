using Structs_Enums;

public enum Premio
{
    malo = 150,
    regular = 250,
    bueno = 400,
    excelente = 550,
};

public class Program
{
    enum Estaciones
    {
        Primavera,
        Verano,
        Otonio,
        Invierno
    };
    
    private static void Main(string[] args)
    {
        /*
        Empleado emp1 = new Empleado(1200, 250);
        emp1.IncrementaSalario(emp1, 100);
        Console.WriteLine(emp1);
        */

        Estaciones alergia = Estaciones.Primavera;
        Console.WriteLine(alergia);

        Empleado juan = new Empleado(Premio.bueno, 1250);
        Console.WriteLine($"El sueldo del empleado es de ${juan.GetSueldo()}");
    }
}

public class Empleado
{
    private double salario;
    private Premio premio;

    public Empleado(Premio premioCumplimiento, double salario)
    {
        this.premio = premioCumplimiento;
        this.salario = salario;
    }

    public double GetSueldo()
    {
        return salario + (double)premio;
    }
}