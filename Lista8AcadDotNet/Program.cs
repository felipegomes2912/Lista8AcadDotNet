namespace Lista8AcadDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /**/
            string nome = "";
            int poder, aux = 0;
            List<Personagem> personagens = new List<Personagem>(3);
            Personagem p = new Personagem();
            int op;

            do
            {
                Console.WriteLine("1 - Inserir um personagem");
                Console.WriteLine("2 - Personagem com maior poder");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolho a opção: ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    if (personagens.Count() >= 3)
                    {
                        Console.Clear();
                        Console.WriteLine("A lista está cheia. Escolha uma nova opção.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Digite um nome para o personagem: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite um poder (de 0 à 10) para o personagem " + nome + ": ");
                        poder = int.Parse(Console.ReadLine());
                        while (poder > 10 || poder < 0)
                        {
                            Console.Write("Digite um poder válido (de 0 à 10): ");
                            poder = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        //Guardando o maior poder
                        if (poder > aux)
                        {
                            aux = poder;
                        }
                        //Adicionando os personagens na lista
                        personagens.Add(new Personagem(nome, poder));
                        Console.WriteLine("Personagem adicionado!");
                        Console.WriteLine();
                    }
                }
                else if (op == 2)
                {
                    if (personagens.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A lista está vazia! Insira um novo personagem.");
                        Console.WriteLine();
                    }
                    else
                    {
                        //Verificando o maior poder e o nome do seu personagem
                        foreach (Personagem maiorPoder in personagens)
                        {
                            if (maiorPoder.poder == aux)
                            {
                                Console.Clear();
                                p.ExibirDados(maiorPoder.nome, maiorPoder.poder);
                            }
                        }
                    }
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do programa.");
                    break;
                }
                else if (op != 1 && op != 2 && op != 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma opção válida.");
                    Console.WriteLine();
                }

            } while (true);




















        }
    }
}