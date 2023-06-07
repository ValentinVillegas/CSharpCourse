internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Circulo circulo1 = new Circulo(8);
        Console.WriteLine($"El área del círculo es de {circulo1.CarlcularArea()} unidades cuadradas.");
        */

        ConversorEuroDolar objeto = new ConversorEuroDolar();
        Console.WriteLine($"Con el tipo de cambio a {objeto.ObtenerPrecioDolar()} dolares, 15 euros equivalen a {objeto.ConvertirEnDolares(15)} dolares.");
        objeto.CambiarPrecioDolar(objeto.ObtenerPrecioDolar() + 0.485);
        Console.WriteLine($"Con el tipo de cambio a {objeto.ObtenerPrecioDolar()} dolares, 15 euros equivalen a {objeto.ConvertirEnDolares(15)} dolares.");

    }
}

class Circulo
{
    private double PI = 3.1416;
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CarlcularArea()
    {
        return this.PI * (this.radio * this.radio);
    }
}

class ConversorEuroDolar
{
    private double precioDolar = 1.253;

    public double ObtenerPrecioDolar()
    {
        return this.precioDolar;
    }

    public void CambiarPrecioDolar(double nuevoPrecio)
    {
        if(nuevoPrecio <= 0)
        {
            Console.WriteLine("El nuevo precio debe ser mayor a cero");
        }
        else
        {
            this.precioDolar = nuevoPrecio;
        }
    }

    public double ConvertirEnDolares(double cantidadEuros)
    {
        return cantidadEuros * this.precioDolar;
    }
}