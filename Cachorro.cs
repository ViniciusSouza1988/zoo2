using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo2
{
    public class Cachorro:Animal
    {
        public Cachorro() : base()
        {
            this.Som = "Au Au Au";
        }

        public Cachorro(string especie, string nome, double idade, string cor, string som) : base(especie, nome, idade, cor, som)
        {
            this.Som = som;
        }
        public string Som { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("Espécie: " + this.Especie);
            if (this.Especie == "Vaca")
            {
                Console.Write("A Vaca está Doente");
            }
            else
            {

            }
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("Cor: " + this.Cor);
            Console.WriteLine("Som emitido: " + this.Som);

        }

    }
}
