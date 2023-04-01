using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo2
{
    public class Animal
    {
        public Animal()
        {
            this.Especie = "";
            this.Nome = "";
            this.Idade = 0;
            this.Cor = "";
            this.Som = "";
        }
        public Animal(string especie, string nome, double idade, string cor, string som)
        {
            this.Especie = especie;
            this.Nome = nome;
            this.Idade = idade;
            this.Cor = cor;
            this.Som = som;
        }

        public string Especie { get; set; }
        public string Nome { get; set; }
        public double Idade { get; set; }
        public string Cor { get; set; }
        public string Som { get; set; }
    }
}
