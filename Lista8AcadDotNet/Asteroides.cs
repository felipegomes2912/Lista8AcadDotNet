using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8AcadDotNet
{
    internal class Asteroides
    {
        private int x, y, tamanho, velocidade, energia;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Energia { get => energia; set => energia = value; }

        public Asteroides()
        {

        }
        public Asteroides(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }
        public Asteroides(int x, int y, int tamanho, int velocidade, int energia)
        {
            this.Tamanho = tamanho;
            this.Velocidade = velocidade;
            this.Energia = energia;
            this.Y = y;
            this.X = x;
        }
    }
}
