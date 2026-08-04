internal class Program
{
    private static void Main(string[] args)
    {
        /* 
            LISTA DE EXERCICIOS 02
        */
        double numero1;
        double numero2;
        double math;

        Console.Write("Número 1: ");
        numero1 = double.Parse(Console.ReadLine());       
        Console.Write("Número 2: ");
        numero2 = double.Parse(Console.ReadLine());       

        Console.WriteLine("Soma");
        Console.WriteLine("Subtração");
        Console.WriteLine("Multiplicação");
        Console.WriteLine("Divisão");


        Console.Write("Escolha uma Opção: ");
        int opcao = int.Parse(Console.ReadLine());
        
        switch (opcao)
        {
            case 1:
                math = numero1 + numero2;
                Console.WriteLine($"A soma do {numero1} e {numero2} é igual a {math}");
                break;
            case 2:
                math = numero1 - numero2;
                Console.WriteLine($"A subtração do {numero1} e {numero2} é igual a {math}");
                break;
            case 3:
                math = numero1 * numero2;
                Console.WriteLine($"A multiplicação do {numero1} e {numero2} é igual a {math}");
                break;
            case 4:
                math = numero1 / numero2;
                Console.WriteLine($"A divisão do {numero1} e {numero2} é igual a {math}");
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }

    }
}