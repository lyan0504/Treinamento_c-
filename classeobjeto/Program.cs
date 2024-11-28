using System;

public class Program
{
    private static void Main(string[] args)
    {
        Carro meuCarro = new Carro();
        meuCarro.Marca = "Ferrari";
        meuCarro.Modelo = "Purosangue ";
        meuCarro.Ano = 2024;

        meuCarro.ExibirInformacoes();
    }
}

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}
