using System.Data;
using System.Runtime.CompilerServices;

namespace Lista8AcadDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
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
            */



            //Exercício 2
            /*
            string nome, raca, tipo;
            int tamanho, contCachorro = 0, contGato = 0, contPeixe = 0;
            Animal animal = new Animal();
            List<Animal> lista = new List<Animal>();

            do
            {
                Console.Write("Nome do animal: ");
                nome = Console.ReadLine();
                animal.SetNome(nome);

                Console.Write("Tipo do animal (cachorro, gato ou peixe): ");
                tipo = Console.ReadLine();
                while (tipo != "Cachorro" && tipo != "Gato" && tipo != "Peixe")
                {
                    Console.Write("Tipo inválido. Digite um novo tipo: ");
                    tipo = Console.ReadLine();
                }

                if (tipo == "Cachorro")
                {
                    contCachorro++;
                }
                else if (tipo == "Gato")
                {
                    contGato++;
                }
                else if (tipo == "Peixe")
                {
                    contPeixe++;
                }

                Console.Write("Raça do animal: ");
                raca = Console.ReadLine();
                animal.SetRaca(raca);

                Console.Write("Tamanho do animal: ");
                tamanho = int.Parse(Console.ReadLine());
                animal.SetTamanho(tamanho);

                lista.Add(animal);
            } while (lista.Count() < 5);

            Console.WriteLine("---------------");
            Console.WriteLine("Total de cachorros: " + contCachorro);
            Console.WriteLine("Total de gatos: " + contGato);
            Console.WriteLine("Total de peixes: " + contPeixe);
            */



            //Exercício 3
            /*
            List<Asteroides> asteroides_lista = new List<Asteroides>();
            Random random = new Random();

            Asteroides asteroides1 = new Asteroides(random.Next(0, 10), random.Next(0, 10), random.Next(1, 5), random.Next(1, 5), random.Next(1, 5));
            asteroides_lista.Add(asteroides1);

            Asteroides asteroides2 = new Asteroides(random.Next(0, 10), random.Next(0, 10), random.Next(1, 5), random.Next(1, 5), random.Next(1, 5));
            asteroides_lista.Add(asteroides2);

            foreach (Asteroides item in asteroides_lista)
            {
                Console.WriteLine("Asteróide " + (asteroides_lista.IndexOf(item) + 1) + ": ");
                Console.WriteLine("Posição: " + "[" + item.X + "," + item.Y + "]");
                Console.WriteLine("Tamanho: " + item.Tamanho);
                Console.WriteLine("Velocidade: " + item.Velocidade);
                Console.WriteLine("Energia: " + item.Energia);
                Console.WriteLine("-------------------");
            }
            */



            //Exercício 4
            /*
            ItemDeCenario item = new ItemDeCenario();
            Console.Write("Altura: ");
            item.Altura = float.Parse(Console.ReadLine());
            Console.Write("Data de criação (DD/MM/AAAA HH/MM/SS): ");
            item.DataCriacao = DateTime.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            item.Descricao = Console.ReadLine();
            Console.WriteLine("----------------------");
            item.ImprimeDados(item.Descricao, item.DataCriacao, item.Altura);
            item.CalculaTempo(item.DataCriacao);
            */



            //Exercício 5
            /**/






















        }
    }
}