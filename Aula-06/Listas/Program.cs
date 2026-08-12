internal class Program
{
    public class Aluno
    {
        public int Id {get; set;}
        public string? Nome {get; set;} /* ? == Campo não obrigatório */
        public string? Matricula {get; set;} 
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("\n=== TRABALHANDO COM LISTAS ===\n");

        // Iniciar uma nova Lista
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno { Id = 1, Nome = "Zuleika", Matricula = "12345"};
        Aluno aluno2 = new Aluno { Id = 2, Nome = "Pafúncio", Matricula = "54321"};
        Aluno aluno3 = new Aluno { Id = 3, Nome = "Asdrúbal", Matricula = "12444\n"};

        // 2 - Incluir Elementos na Lista
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2);
        listaAlunos.Add(aluno3);

        // 3 - Percorrer todos Elementos de uma Lista
        foreach(var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 4 - Alterar um Elemento da Lista 
        listaAlunos[1].Matricula = "5555";
        listaAlunos[2].Nome = "Eleutério";

        Console.WriteLine();
        Console.WriteLine("=== LISTA ATUALIZADA ===\n");
        foreach(var aluno in listaAlunos)
        {   
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 5 - Remover um Elemento da Lista por ídice
        listaAlunos.RemoveAt(0);

        Console.WriteLine();
        Console.WriteLine("=== LISTA ATUALIZADA ===\n");
        foreach(var aluno in listaAlunos)
        {   
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 6 - Remover um Elemento da Lista por objeto
        listaAlunos.Remove(aluno3);

        Console.WriteLine();
        Console.WriteLine("=== LISTA ATUALIZADA ===\n");
        foreach(var aluno in listaAlunos)
        {   
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 7 - Quantidade de Elementos da Lista
            Console.WriteLine($"\nQuantidade de Elementos na Lista: {listaAlunos.Count()}\n");

        // 8 - Remover todos os Elementor da Lista
            listaAlunos.Clear();   
    }
}