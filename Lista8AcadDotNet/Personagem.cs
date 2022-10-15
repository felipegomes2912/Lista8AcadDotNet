using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8AcadDotNet
{
    internal class Personagem
    {

        public string nome;
        public int poder;

        public Personagem(){}

        public Personagem(string nome, int poder)
        {
            this.nome = nome;
            this.poder = poder;
        }
        public void ExibirDados(string nome, int poder)
        {
            Console.WriteLine("Personagem com maior poder: " + nome + "\nMaior poder: " + poder);
            Console.WriteLine();
        }


    }


}
