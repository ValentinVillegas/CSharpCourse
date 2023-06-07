using Genericos;

public class Program
{
    private static void Main(string[] args)
    {
        /*
        AlmacenObjetos<String> contenedorObjetos = new AlmacenObjetos<String>(4);
        String elemento;
        contenedorObjetos.AgregarElemento("Juan");
        contenedorObjetos.AgregarElemento("Carlos");
        contenedorObjetos.AgregarElemento("Gabriela");
        contenedorObjetos.AgregarElemento("Fernanda");
        elemento = contenedorObjetos.ObtenerElemento(2);
        Console.WriteLine(elemento);
        */

        
        AlmacenObjetos<Empleado> contenedorObjetos = new AlmacenObjetos<Empleado>(4);
        Empleado elemento;
        contenedorObjetos.AgregarElemento(new Empleado(1500));
        contenedorObjetos.AgregarElemento(new Empleado(2500));
        contenedorObjetos.AgregarElemento(new Empleado(3500));
        contenedorObjetos.AgregarElemento(new Empleado(4500));
        elemento = contenedorObjetos.ObtenerElemento(2);
        Console.WriteLine(elemento.GetSalario());
    }
}