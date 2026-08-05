using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Sintaxe:
                Enquanto uma condição for verdadeira
                    execute um conjunto de comandos
                for -> Quando sabemos a quantidade de repetições
                while -> Quando s repetição depende de uma condição
                do ... while ->   Quando precisa executar ao menos uma vez o bloco de códigio    
        */

        /* Laço for: Imprimir número de 1 a 10 */

        Console.WriteLine("Imprimir números de 1 até 10, utilizando o laço for");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }

        /* Laço for: Contagem regressiva de 10 até 0 */
        Console.WriteLine("Imprimir Contagem Regressiva");
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }

        /****************************************************/

        /* Laço While */

        Console.WriteLine("Imprimir números de 1 até 10, utilizando o laço while");

        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        /* Soloicitar a senha até acertar */

        string senha = "";

        while(senha != "2444")
        {
            Console.Write("Digite a senha: "); //Usuário digitar algo (exemplo senha): Write 

            senha = Console.ReadLine();
        }

        Console.WriteLine("Acesso Permitido!");

        /****************************************************/

        int num;
        do //faz
        {
            Console.Write("Digite um Número Positivo: ");
            num = int.Parse(Console.ReadLine());
        }while(num <=0 );

    }
}