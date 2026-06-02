using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double iof = 0.06;

            Console.WriteLine("qual e a cotacao do dolar?");
            double cot = double.Parse(Console.ReadLine());

            Console.WriteLine("quanto vc vai comprar?");
            double valor = double.Parse(Console.ReadLine());

            double real = cot * valor;
            double tot = real + real * iof;

            Console.WriteLine("voce pagara R$" + tot);
        }
    }
}
