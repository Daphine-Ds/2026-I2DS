internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> RegistroAcoes = new Stack<string>();

        Console.WriteLine("\n=== REGISTRO DE AÇÕES ===");

        RegistroAcoes.Push("Digitar");
        RegistroAcoes.Push("Colar");
        RegistroAcoes.Push("Negrito");
        RegistroAcoes.Push("Apagar");

        foreach (var item in RegistroAcoes)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine("");


        string acao1 = RegistroAcoes.Pop();
        Console.WriteLine();
        Console.WriteLine($"A Ação foi feita: {acao1}");

        string acao2 = RegistroAcoes.Pop();
        Console.WriteLine($"A Ação foi desfeita: {acao2}");
        Console.WriteLine();

        foreach (var item in RegistroAcoes)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine("");
    }
}
