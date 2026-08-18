internal class Program
{
    public class Aluno
    {
        public int Idade {get; set;}
        public string? Nome {get; set;}
    }
    private static void Main(string[] args)
    {
        /* ## 🟢 Exercício 02 — Cadastro de Alunos

        Crie uma classe `Aluno` com as propriedades:

        - `Nome`
        - `Idade`

        Cadastre 5 alunos utilizando uma `List<Aluno>`.

        O programa deve:

        1. Exibir todos os alunos.
        2. Permitir alterar a idade de um aluno.
        3. Permitir remover um aluno pelo nome.
        4. Exibir a lista final.

       **Conceitos:** `List<T>`, objetos, pesquisa, alteração e remoção. */

        /* Aluno */

        Console.WriteLine("=== LISTA DE ALUNOS   ===\n");

        List<Aluno> listaAluno = new List<Aluno>();

        Aluno aluno1 = new Aluno {Nome = "Daphine", Idade = 12};
        Aluno aluno2 = new Aluno {Nome = "Sofia", Idade = 16};
        Aluno aluno3 = new Aluno {Nome = "Lívia", Idade = 18};
        Aluno aluno4 = new Aluno {Nome = "Lucas", Idade = 11};
        Aluno aluno5 = new Aluno {Nome = "Jurandir", Idade = 14};

        foreach(var aluno in listaAluno)
        {   
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }

        // 4 - Alterar um Elemento da Lista 
        listaAluno[1].Nome = "17";

        Console.WriteLine();
        Console.WriteLine("=== LISTA ATUALIZADA ===\n");
        foreach(var aluno in listaAluno)
        {   
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
    }
}