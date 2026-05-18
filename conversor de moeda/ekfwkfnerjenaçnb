using System;
using System.Globalization;

class ConversorDeMoeda
{
    public static double IOF = 0.06;

    public static double Converter(double cotacaoDolar, double quantidadeDolar)
    {
        double valorSemIOF = cotacaoDolar * quantidadeDolar;
        return valorSemIOF + (valorSemIOF * IOF);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Qual é a cotação do dólar? ");
        double cotacao = double.Parse(Console.ReadLine(), CI);

        Console.Write("Quantos dólares você vai comprar? ");
        double quantidade = double.Parse(Console.ReadLine(), CI);

        double valorFinal = ConversorDeMoeda.Converter(cotacao, quantidade);

        Console.WriteLine("Valor a ser pago em reais = "
            + valorFinal.ToString("F2", CI));
    }
}
