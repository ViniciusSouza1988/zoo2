using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using zoo2;

namespace Zoo2
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cadastro dos animais!");
            Console.WriteLine("---------------------");


            int valor = 0;
            Animal animal = new Animal();

            do
            {
            
            Console.Write("Especie: ");
            animal.Especie = Console.ReadLine();
            Console.Write("Nome: ");
            animal.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            animal.Idade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cor: ");
            animal.Cor = Console.ReadLine();

            if (animal.Especie == "Vaca")
            {
                Console.WriteLine("Esse animal está doente");
            }
            else
            {
                Console.WriteLine("Esse animal está Saldável");
            }

            if (animal.Especie == "Cachorro")
            {
                Console.WriteLine("Esse animal possui manchas");
            }
            else
            {
                Console.WriteLine("Esse animal não possui manchas");
            }

            if (animal.Especie == "Vaca")
            {
                Console.WriteLine("O som emitido é: Muuuuuuuuuu ");
            }
                if (animal.Especie == "Cachorro")
            {
                    Console.WriteLine("O som emitido é: Au Au Au ");
            }
                if (animal.Especie == "Gato")
                {
                    Console.WriteLine("O som emitido é: Miauuuuuu");
            }
            
            Console.Write("Deseja Cadastrar outro animal ? ");
            Console.WriteLine("Digite: 0 - para SIM ou 1 para NÃO");
            valor = Convert.ToInt32(Console.ReadLine());
                
            } while (valor < 1);
        }
    }
}