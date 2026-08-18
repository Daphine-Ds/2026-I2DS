internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n=== CIDADES MARAVILHOSAS ===");
        Console.WriteLine("");


        List<Cidade> listaCidade = new List<Cidade>();

        Cidade Cidade1 = new Cidade{Nome = "Jaú"};
        Cidade Cidade2 = new Cidade{Nome = "Itapuí"};
        Cidade Cidade3 = new Cidade{Nome = "Foz do Iguaçu"};
        Cidade Cidade4 = new Cidade{Nome = "Aquidauana"};
        Cidade Cidade5 = new Cidade{Nome = "Aparecida do Norte"};

        listaCidade.Add(Cidade1);
        listaCidade.Add(Cidade2);
        listaCidade.Add(Cidade3);
        listaCidade.Add(Cidade4);
        listaCidade.Add(Cidade5);

        foreach (var city in listaCidade)
        {
            Console.WriteLine($"{city.Nome}");
        }

        Console.WriteLine("");

    }

    public class Cidade
    {
        public string? Nome { get; set; }
    }
}