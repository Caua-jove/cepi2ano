using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Funcionário 1:");
            Console.WriteLine("Nome: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário 2:");
            Console.WriteLine("Nome: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Média salarial: " + media);
        }
    }
}

--Funcionario.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Funcionario
    {
        public string nome;
        public double salario;
    }
}
