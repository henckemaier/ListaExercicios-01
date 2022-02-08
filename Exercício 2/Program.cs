using System;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal PrecoPao = 0.12m;
            decimal PrecoBroa = 1.50m;

            decimal valorPaes, valorBroas, total = 0.0m;
            decimal poupanca;

            ////////////////////////////////
            Console.WriteLine("======Contador de pães e broas========");

            Console.ReadKey();

            Console.Write("Qual a quantidade de pães vendidos? ");
            int paesVendidos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual a quantidade de broas vendidas? ");
            int broasVendidas = Convert.ToInt32(Console.ReadLine());

            /////////////////////////////

            valorPaes = paesVendidos * PrecoPao;
            valorBroas = broasVendidas * PrecoBroa;

            total = valorPaes + valorBroas;
            poupanca = total * 0.1m;

            //////////////////////////////

            Console.Write("Ao todo deu: R$" + total);
            Console.Write("O que vai para a poupança: R$" + poupanca);
            Console.ReadKey();

        }
    }
}
