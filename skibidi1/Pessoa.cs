using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados pessoa 1");
            Console.WriteLine("Nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados pessoa 2");
            Console.WriteLine("Nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine(p1.nome + " é mais velho");
            }
            else
            {
                Console.WriteLine(p2.nome + " é mais velho");
            }

        }
    }
}
