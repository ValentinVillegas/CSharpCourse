internal class Program
{
    private static void Main(string[] args)
    {
        Coche coche1 = new Coche(2300.5, 0.800);
        coche1.setExtras(true, "Cuero");
        Console.WriteLine(coche1.GetInfoCoche());
    }
}

class Coche
{
    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private string tapiceria;

    public Coche(double largo, double ancho)
    {
        this.ruedas = 4;
        this.largo = largo;
        this.ancho = ancho;
        this.tapiceria = "Tela";
    }

    public void setExtras(bool tieneClima, string tapiceria)
    {
        this.climatizador = tieneClima;
        this.tapiceria=tapiceria;
    }

    public string getExtras()
    {
        return $"====== Extras del coche: ======" +
            $"\nTiene aire acondicionado: {climatizador}" +
            $"\nTapiceria: {this.tapiceria}";
    }

    public string GetInfoCoche()
    {
        return $"====== Información del coche: ======" +
            $"\nCantidad de ruedas: {this.ruedas}" +
            $"\nLargo: {this.largo}" +
            $"\nAncho: {this.ancho}" + "\n" + getExtras();
    }
}