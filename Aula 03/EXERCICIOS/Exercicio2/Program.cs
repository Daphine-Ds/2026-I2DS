internal class Program
{
    private static void Main(string[] args)
    {
        /* 
            LISTA DE EXERCICIOS 02
        */
        int numero1;
        int numero2;
        Console.Write("Digite o Primeiro Número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        string operacao;
        
        Console.Write("Selecione uma Operação: ");
        operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1": 
                Console.WriteLine(numero1 + numero2);
                break;
            case "2": 
                Console.WriteLine(numero1 - numero2);
                break;
            case "3": 
                Console.WriteLine(numero1 * numero2);
                break;
            case "4": 
                Console.WriteLine(numero1 / numero2);
                break;
            default:
                Console.WriteLine("Operador inválido.");
                break;
        }
    }
}