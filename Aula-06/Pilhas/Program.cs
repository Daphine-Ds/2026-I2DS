internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n=== TRABALHANDO COM PILHAS ===");

        // 1 - Criar uma nova Pilha vazia
        Stack<string> pilhaLivros = new Stack<string>();

        // 2 - Adicionar Elementos em uma Pilha
        pilhaLivros.Push("Dom Quixote");
        pilhaLivros.Push("O Morro dos Ventos Uivantes");
        pilhaLivros.Push("O Cortiço");

        // 3 - Percorrer todos Elementos de uma Pilha
        Console.WriteLine();

        foreach(var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }

        // 4 - Remover um Elemento da Pilha
        string livroRemovido = pilhaLivros.Pop();
        Console.WriteLine();

        Console.WriteLine($"O Livro retirado foi: {livroRemovido}");

        pilhaLivros.Push("Dom Casmurro");
        Console.WriteLine();
        Console.WriteLine();
        foreach(var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }
    }
}