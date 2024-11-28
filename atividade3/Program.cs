
internal class Program
{
    private static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        retangulo.largura = 10.0;
        retangulo.altura = 5.0;
        
        double area = retangulo.CalcularArea();
        Console.WriteLine($"A área do retângulo é: {area}");
    }
}

public class Retangulo
{
    public double largura { get; set; }
    public double altura { get; set; }

    public double CalcularArea()
    {
        return largura * altura;
    }
}
