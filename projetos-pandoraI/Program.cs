using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace josivane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou:");
            Console.WriteLine(n1);
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou:"+ch);
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou: " + n2);
            Console.WriteLine(n2.ToString("f2", CultureInfo.InvariantCulture));




            string[] vet3 = Console.ReadLine().Split(' ')int idade = int.Parse(vet3[2]);
            double altura = double.Parse(vet3[3]);
;
            string nome = vet3[0];
            char sexo = char.Parse(vet3[1]);
                        Console.WriteLine("----------------------");
            Console.WriteLine("voce digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura.ToString("F2" , CultureInfo.InvariantCulture));



            Console.WriteLine("entre com seu nome completo: ");
            string nomecomple = Console.ReadLine();
            Console.WriteLine("quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());
            Console.WriteLine("entre seu ultimo nome, idade e altura (mesma linha ");
            string[] vetor1 = Console.ReadLine().Split(',');
            string sobrenome = vetor1[0];
            int idade1 = int.Parse(vetor1[1]);
            double altura1 = 
         
        }
    }
}
