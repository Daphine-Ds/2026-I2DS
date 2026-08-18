internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n=== PAINEL DE ATENDIMENTOS ===");
        Console.WriteLine("");

        Queue<string> filaAtendimento = new Queue<string>();

        filaAtendimento.Enqueue("Daphine");
        filaAtendimento.Enqueue("Sofia");
        filaAtendimento.Enqueue("Lívia");
        filaAtendimento.Enqueue("Guilherme");
        filaAtendimento.Enqueue("Davi");
        filaAtendimento.Enqueue("João Vitor");
        filaAtendimento.Enqueue("Bruno");

        // Chamada das Pessoas

        string pessoaSala16 = filaAtendimento.Dequeue();
        Console.WriteLine();
        Console.WriteLine("=== ATENÇÃO ===\n");

        Console.WriteLine($"CHAMADA: {pessoaSala16} | Consultório: SALA 16");
        Console.WriteLine("\nPacientes aguardando a serem chamados: \n");

        foreach (var pessoa in filaAtendimento)
        {
            Console.WriteLine($"{pessoa}");
        }

        Console.WriteLine();
        Console.WriteLine("=== ATUALIZAÇÃO DA FILA DE ATENDIMENTOS ===");;

        string pessoaSala26 = filaAtendimento.Dequeue();
        Console.WriteLine();

        Console.WriteLine("=== ATENÇÃO ===\n");
        Console.WriteLine($"CHAMADA: {pessoaSala26} | Consultório: SALA 26");
        Console.WriteLine("\nPacientes aguardando a serem chamados: \n");

        foreach (var pessoa in filaAtendimento)
        {
            Console.WriteLine($"- {pessoa}");
        }
        Console.WriteLine();
    }
}