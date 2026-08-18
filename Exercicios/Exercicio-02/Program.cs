internal class Program
{
    public class Numero
    {
        public int num { get; set; }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("==== LISTA DE NUMEROS ====");
        Console.WriteLine("");


        List<int> Numeros = new List<int>{ 10, 25, 8, 42, 15, 30 };

        foreach (var item in Numeros)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine("\n=== ADICIONANDO O NUMERO ===");
        
        Numeros[2] = 100;

        foreach (var item in Numeros)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine("\n==== REMOVENDO O NUMERO ====");

        Numeros.RemoveAt(5);

        foreach (var item in Numeros)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine("");
    }
}