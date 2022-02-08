using System;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal vAumento = 0.15m;
            decimal impostos = 0.8m;

            decimal sAtual, sAumento, sFinal;

            Console.WriteLine("===========Calculadora de Salário===========");
            Console.ReadKey();

            Console.Write("Digite o seu salário inicial: ");
            sAtual = Convert.ToDecimal(Console.ReadLine());

            sAumento = sAtual + sAtual * vAumento;

            sFinal = sAumento - sAumento * impostos;

            Console.WriteLine("O seu salário com aumento de 15% fica: " + sAumento + " Reais");
            Console.ReadKey();
            Console.WriteLine("O salário final com 8% em imposto é: " + sFinal + " Reais");
            Console.ReadKey();
        }
    }
}

/* Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final.*/