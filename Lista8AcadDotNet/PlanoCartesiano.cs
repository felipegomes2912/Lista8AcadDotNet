using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8AcadDotNet
{
    internal class PlanoCartesiano
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public PlanoCartesiano() { }
        public void ExibirXY(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("Valor de X: " + X);
            Console.WriteLine("Valor de Y" + Y);
        }
    }
}
