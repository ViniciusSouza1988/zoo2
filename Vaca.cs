using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo2
{
    public class Vaca:Animal
    {
        public Vaca() : base()
        {
            this.Som = "Muuuuuuuuuu";    
        }

        public Vaca(string especie, string nome, double idade, string cor, string som) : base(especie, nome, idade, cor, som)
        {
            this.Som = Som;
        }
        public string Som { get; set; }

        public void ExibirDados() 
        {
            Console.WriteLine("Espécie: " +  this.Especie);
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
