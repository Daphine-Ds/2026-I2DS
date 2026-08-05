internal class Program
{
    static void Main(string[] args)
    {

        /* LISTA DE EXERCICIOS - Exercicio 07 */

        double[] notas = new double[3];

        // Recebendo as notas
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Digite a nota do aluno " + (i + 1) + ": ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        // Calculando soma || maior nota || menor nota || aprovados da turma
    
        double maior = notas[0];
        double menor = notas[0];
        double soma = 0;
        int aprovados = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];

            if (notas[i] > maior)
            {
                maior = notas[i];
            }
            if (notas[i] < menor)
            {
                menor = notas[i];
            }
            if (notas[i] >= 7)
            {
                aprovados++;
            }
        }

        // Calculando média final da turma

        double media = soma / notas.Length;

        Console.WriteLine("===== Resultado da Turma =====");
        Console.WriteLine("Maior nota: " + maior);
        Console.WriteLine("Menor nota: " + menor);
        Console.WriteLine("Média total da turma: " + media);
        Console.WriteLine("Quantidade de alunos Aprovados: " + aprovados);
    }
}