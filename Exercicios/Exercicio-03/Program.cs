internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<int, string> Cardapio = new Dictionary<int, string>();

        Console.WriteLine("\n=== CARDÁPIO McDonald's ===");
        Console.WriteLine("");

        Cardapio.Add(1, "Big Mac");
        Cardapio.Add(2, "McLanche Feliz");
        Cardapio.Add(3, "McFlurry Creme Crocante");
        Cardapio.Add(4, "Cheddar Mc Melt");
        Cardapio.Add(5, "Duplo Burguer");
        Cardapio.Add(6, "McFritas");


        foreach (var item in Cardapio)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine("");
        
    }
}