
public class Program
{
    private static void Main(string[] args)
    {

        Produto meuProduto = new Produto();


        meuProduto.Nome = "Notebook";
        meuProduto.Preco = 2500.00;
        meuProduto.Quantidade = 3;

        double valorTotal = meuProduto.CalcularValorTotal();
        Console.WriteLine($"Produto: {meuProduto.Nome}");
        Console.WriteLine($"Preço unitário: {meuProduto.Preco}");
        Console.WriteLine($"Quantidade: {meuProduto.Quantidade}");
        Console.WriteLine($"Valor total: {valorTotal}");
    }
}

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}
