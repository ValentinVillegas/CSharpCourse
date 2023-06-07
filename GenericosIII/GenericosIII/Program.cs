using GenericosIII;

public class Program
{
    private static void Main(string[] args)
    {
        AlmacenObjetos<Director> contenedorDirectores = new AlmacenObjetos<Director>(3);
        contenedorDirectores.AgregarObjeto(new Director(2500));
        contenedorDirectores.AgregarObjeto(new Director(2800));
        contenedorDirectores.AgregarObjeto(new Director(3000));
        Console.WriteLine(contenedorDirectores.ObtenerObjeto(1).GetSalario());


        AlmacenObjetos<Secretaria> contenedorSecretarias = new AlmacenObjetos<Secretaria>(3);
        contenedorSecretarias.AgregarObjeto(new Secretaria(1800));
        contenedorSecretarias.AgregarObjeto(new Secretaria(2000));
        contenedorSecretarias.AgregarObjeto(new Secretaria(2100));

        //Marca error porque la clase Estudiante no implementa IEmpleado y esta es una condición de la clase genérica.
        /*
        AlmacenObjetos<Estudiante> contenedorEstudiantes = new AlmacenObjetos<Estudiante>(3);
        contenedorEstudiantes.AgregarObjeto(new Estudiante(19.6));
        */
    }
}