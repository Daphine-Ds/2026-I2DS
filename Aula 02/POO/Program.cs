internal class Program
{
    private static void Main(string[] args)
    {

        //Comentário de linha
        /* 
        Comentário 
        de
        varias 
        linhas
        */

        //Escreve uma linha de texto na tela
        Console.WriteLine("Programação Orienta a Objetos\n");
        
        Console.WriteLine("Abstração - 1º Pilar da POO");

        /* Criar uma classe em C# 
        A classe deveve ser declarada fora do bloco de programa*/

        /*Criar um Objeto Apartir de uma classe*/

        Pet pet1 = new Pet();

        pet1.nome = "Totó";
        pet1.tipo = "Cachorro";
        pet1.idade = 3;

        pet1.MostrarNome();

        Pet pet2 = new Pet();

        pet2.nome = "Mingau";
        pet2.tipo = "Gato";
        pet2.idade = 8;

        pet2.MostrarNome();
    }
        public class Pet // Nome da ckasse smpre inicia com letras MAIUSCULAS
    {
        
        // Declaração dos Atributos

        public string nome;
        public string tipo;
        public int idade;

        // Declaração dos Métodos

        public void MostrarNome()
        {
            Console.WriteLine("Meu nome é " + this.nome);
        }
    } 
}       