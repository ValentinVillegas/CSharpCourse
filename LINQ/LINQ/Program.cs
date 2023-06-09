using LINQ;

public class Program
{
    private static void Main(string[] args)
    {
        /*
        int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

        foreach (int n in numerosPares)
        {
            Console.WriteLine(n);
        }
        */

        ControlEmpleados empleados = new ControlEmpleados();
        empleados.GetCEO();

        Console.WriteLine("=========== Empleados Ordenados ===========");
        empleados.GetEmpleadosOrdenados();

        Console.WriteLine("=========== Filtro por Id de Empresa 1 ===========");
        empleados.GetEmpleadosByEmpresa(1);

        Console.WriteLine("=========== Filtro por Id de Empresa 2 ===========");
        empleados.GetEmpleadosByEmpresa(2);
    }
}