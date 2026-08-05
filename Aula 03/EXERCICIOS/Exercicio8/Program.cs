internal class Program
{
    private static void Main(string[] args)
    {
        /* LSITA DE EXERCICIO - Exercicio 08 */
        
        string usuarioCorreto = "Daphine";
        string senhaCorreta = "1234";

        int tentativas = 0;
        bool acesso = false;

        while(tentativas < 3)
        {
            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();
            
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if(usuario == usuarioCorreto && senha == senhaCorreta)
            {
                acesso = true;
                break;
            }
            tentativas++;

            Console.WriteLine("Usuário ou senha incorretos.");
        }
        Console.WriteLine();

        if(acesso)
        {
            Console.WriteLine("Login realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Acesso bloqueado.");
        }
    }
}