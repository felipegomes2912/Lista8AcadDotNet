using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista8AcadDotNet
{
    internal class Animal
    {
        
        private string nome;
        private string raca;
        private int tamanho;
        
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetRaca(string raca)
        {
            this.raca = raca;
        }
        public void SetTamanho(int tamanho)
        {
            this.tamanho = tamanho;
        }

        public string GetNome()
        {
            return this.nome;
        }
        public string GetRaca()
        {
            return raca;
        }
        public int GetTamanho()
        {
            return tamanho;
        }
    }
}
