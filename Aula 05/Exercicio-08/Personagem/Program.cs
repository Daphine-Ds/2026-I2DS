
internal class Program
{
    private static void Main(string[] args)
    {
        /* Personagem */

        // Mago
        Herois mago = new Herois(
            "Mago Gui",// nome
            2,// nível
            15,// força
            0.5,// agilidade
            3,// inteligência
            100// vida
        );

        // Elfo
        Herois elfo = new Herois(
            "Elfo Perosa",// nome
            4, // nível
            10,// força
            10, // agilidade
            2,// inteligência
            100// vida
        );

        // Cavaleiro
        Herois cavaleiro = new Herois(
            "Cavaleiro Gi", // nome
            3, // nível
            0, // força
            10, // agilidade
            1, // inteligência
            100 // vida
        );


        // Escolhendo o personagem pelo nome

        Console.WriteLine("=== PERSONAGENS ===");

        Console.WriteLine("Mago Gui");
        Console.WriteLine("Elfo Perosa");
        Console.WriteLine("Cavaleiro Gi");

        Console.Write("\nDigite o nome do personagem: ");
        string escolha = Console.ReadLine();

        Herois personagemEscolhido = null;

        if (escolha.ToLower() == mago.Nome.ToLower())
        {
            personagemEscolhido = mago;
        }
        else if (escolha.ToLower() == elfo.Nome.ToLower())
        {
            personagemEscolhido = elfo;
        }
        else if (escolha.ToLower() == cavaleiro.Nome.ToLower())
        {
            personagemEscolhido = cavaleiro;
        }
        else
        {
            Console.WriteLine("Personagem não encontrado!");
            return;
        }


        // Menu das ações

        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Apresentar personagem");
            Console.WriteLine("2 - Evoluir personagem");
            Console.WriteLine("3 - Atacar personagem");
            Console.WriteLine("4 - Defender");
            Console.WriteLine("5 - Sair");

            Console.Write("\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());


            // Apresentar

            if (opcao == 1)
            {
                personagemEscolhido.Apresentar();
            }


            // Evoluir

            else if (opcao == 2)
            {
                personagemEscolhido.Evoluir();
            }


            // Atacar

            else if (opcao == 3)
            {
                Console.WriteLine("\n=== ESCOLHA O ALVO ===");

                Console.WriteLine("Mago Gui");
                Console.WriteLine("Elfo Perosa");
                Console.WriteLine("Cavaleiro Gi");

                Console.Write("\nDigite o nome do alvo: ");
                string alvoNome = Console.ReadLine();

                Herois alvo = null;

                if (alvoNome.ToLower() == mago.Nome.ToLower())
                {
                    alvo = mago;
                }
                else if (alvoNome.ToLower() == elfo.Nome.ToLower())
                {
                    alvo = elfo;
                }
                else if (alvoNome.ToLower() == cavaleiro.Nome.ToLower())
                {
                    alvo = cavaleiro;
                }
                else
                {
                    Console.WriteLine("Personagem não encontrado!");
                    continue;
                }
            }
        }
    }     


    public class Personagem
    {
        public string Nome { get; protected set; }
    }


    public class Herois : Personagem
    {
        public int Nivel { get; protected set; }
        public int Forca { get; protected set; }
        public double Agilidade { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Vida { get; protected set; }

        // Indica se o personagem está se defendendo
        protected bool EstaDefendendo { get; set; }


        public Herois(
            string nome,
            int nivel,
            int forca,
            double agilidade,
            int inteligencia,
            int vida)
        {
            Nome = nome;
            Nivel = nivel;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }


        // Método para apresentar o personagem

        public void Apresentar()
        {
            Console.WriteLine("\n=== APRESENTAÇÃO ===");

            Console.WriteLine("Olá! Eu sou " + Nome + "!");
        }


        // Método para evoluir

        public void Evoluir()
        {
            Nivel++;
            Forca += 5;
            Agilidade += 1;
            Inteligencia += 1;
            Vida += 20;

            Console.WriteLine("\n" + Nome + " evoluiu!");
            Console.WriteLine("Novo nível: " + Nivel);
            Console.WriteLine("Força: " + Forca);
            Console.WriteLine("Agilidade: " + Agilidade);
            Console.WriteLine("Inteligência: " + Inteligencia);
            Console.WriteLine("Vida: " + Vida);
        }


        // Método para atacar

        

        // Método para receber dano



        // Método para defender

        
    }
}   
