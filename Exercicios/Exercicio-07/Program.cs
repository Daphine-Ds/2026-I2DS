internal class Program
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Tranqueiras do Girilini ===");

        List<Produto> listaProdutos = new List<Produto>();

        Produto produto1 = new Produto { ID = 1, Nome = "Caixa do Som", Preco = 34.90 };
        Produto produto2 = new Produto { ID = 2, Nome = "Lixa de unha", Preco = 1.99 };
        Produto produto3 = new Produto { ID = 3, Nome = "Maquina de lavar", Preco = 155.95 };
        Produto produto4 = new Produto { ID = 4, Nome = "Ventilador de Telo", Preco = 799.99 };
        Produto produto5 = new Produto { ID = 5, Nome = "Xicara", Preco = 87.64 };

        listaProdutos.Add(produto1);
        listaProdutos.Add(produto2);
        listaProdutos.Add(produto3);
        listaProdutos.Add(produto4);
        listaProdutos.Add(produto5);


        ImprimirLista(listaProdutos);
        
        var filtro = listaProdutos.Where(Prod => Prod.Preco >= 50).ToList();

        Console.WriteLine("=== Produtos selecionados pelo Filtro ===");

        ImprimirLista(filtro);
    }

    public static void ImprimirLista(List<Produto> lista)
    {
        Console.WriteLine();
        foreach (var Prod in lista)
        {
            Console.WriteLine($"| ID: {Prod.ID}\n| Nome: {Prod.Nome}\n| Preço: R${Prod.Preco}\n");
        }
    }
}
