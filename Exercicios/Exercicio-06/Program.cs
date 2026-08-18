internal class Program
{
    private static void Main(string[] args)
    {
        Func<int, int, int> multiplicar = (valor1, valor2) => valor1 * valor2;

        int valor1 = 16;
        int valor2 = 26;
        int resultado = multiplicar(valor1, valor2);

        Console.WriteLine("\n=== MULTIPLICAÇÃO ===");
        Console.WriteLine($"O resultado da multiplicação de {valor1} e {valor2} é: {resultado}");
        Console.WriteLine("");
    }
}