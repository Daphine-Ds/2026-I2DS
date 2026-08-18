internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n=== TRABALHANDO COM FILAS (FIFO) ===");

        // 1 - Criar uma nova Fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar Elementos na Fila
        filaBanco.Enqueue("Daphine");    // 0
        filaBanco.Enqueue("Lívia");     // 1
        filaBanco.Enqueue("Sofia");    // 2
        filaBanco.Enqueue("Gilo");    // 3

        // 3 - Percorrer Elementos de um Fila
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Retirar um Elemento da Lista
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

        filaBanco.Enqueue("Guilherme");
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 5 - Verificar se existe um determinado Elemento na Lista
        string procurar = "Lívia";

        bool achou = filaBanco.Contains(procurar);

        Console.WriteLine();
        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} não está na fila");
        }
        Console.WriteLine();
    }
}