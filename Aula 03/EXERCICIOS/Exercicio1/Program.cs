internal class Program
{
    private static void Main(string[] args)
    {
        /*
            LISTA DE EXERCICIOS 01
        */

        int gCelsius;
        Console.Write("Digite a temperatura em Graus Celsius: ");
        gCelsius = int.Parse(Console.ReadLine());

        double gFahrenheit = (gCelsius * 9 / 5) + 32;

        Console.WriteLine("A temperatura convertida em Fahrenheit é: " + gFahrenheit);
    }
}