using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8AcadDotNet
{
    internal class ItemDeCenario
    {
        private string descricao;
        private DateTime data = DateTime.Now;
        private DateTime dataCriacao = new DateTime(2021, 12, 16, 17, 47, 51);
        private float altura;

        public ItemDeCenario() { }

        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public float Altura { get => altura; set => altura = value; }

        public void ImprimeDados(string descricao, DateTime dataCriacao, float altura)
        {
            this.Descricao = descricao;
            this.DataCriacao = dataCriacao;
            this.Altura = altura;

            Console.WriteLine("Dados: ");
            Console.WriteLine("Descrição: " + Descricao + "\nData: " + DataCriacao + "\nAltura: " + Altura);
        }
        public void CalculaTempo(DateTime dataCriacao)
        {
            this.DataCriacao = dataCriacao;
            Console.WriteLine("Tempo desde a criação: " + (data - DataCriacao)); //Verificar com o professor
        }
    }
}
