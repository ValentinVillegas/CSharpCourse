internal class Program
{
    private static void Main(string[] args)
    {
        StreamReader archivo = null;

        try
        {
            string linea;
            int contador = 0;
            string path = @"C:\Cursos\CSharp Pildoras\EjemploFinally\ArchivoPrueba.txt";

            archivo = new StreamReader(path);

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error con la lectura del archivo");
        }
        finally
        {
            if (archivo != null) archivo.Close();
            Console.WriteLine("Se cerró la conexión con el archivo de texto");
        }

    }
}