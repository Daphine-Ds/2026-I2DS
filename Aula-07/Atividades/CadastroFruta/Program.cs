internal class Program
{
    public class Fruta{
    public string? Nome {get; set;} /* ? == Campo não obrigatório */
    }
    private static void Main(string[] args)
    {
        /* Exercício 01 — Cadastro de Frutas

            Crie um aplicativo Console que utilize uma `List<string>` para armazenar nomes de frutas.

            O programa deve:

        - Adicionar inicialmente 5 frutas.
        - Exibir todas as frutas cadastradas.
        - Solicitar ao usuário uma nova fruta.
        - Adicionar a nova fruta à lista.
        - Exibir novamente a lista atualizada.

       **Conceitos:** `List`, `Add`, `foreach`. */

        Console.WriteLine("\n=== CADASTRO DE FRUTAS ===");

        // 1 - Criar uma lista de Frutas
        List<Fruta> listaFrutas = new List<Fruta>();

        Fruta fruta1 = new Fruta {Nome = "Maçã"};
        Fruta fruta2 = new Fruta {Nome = "Banana"};
        Fruta fruta3 = new Fruta {Nome = "Cacau"};
        Fruta fruta4 = new Fruta {Nome = "Pocã"};
        Fruta fruta5 = new Fruta {Nome = "Tomate"};

        // 2 - Inciar Elementos de uma Lista
        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2);
        listaFrutas.Add(fruta3);
        listaFrutas.Add(fruta4);
        listaFrutas.Add(fruta5);

        // 3 - Percorrrer os Elementos
        Console.WriteLine();
        foreach(var fruta in listaFrutas)
        {
            Console.WriteLine(fruta.Nome);
        }

        // 4 - Nova Fruta
        Fruta fruta6 = new Fruta {Nome = "Pitaya"};

        listaFrutas.Add(fruta6);
        Console.WriteLine();

        Console.WriteLine("=== NOVA LISTA ATUALIZADA ===\n");
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }     
    }
}