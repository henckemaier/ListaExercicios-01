using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorDigitado, nome;
            bool numeroInteiro;
            double idade = 0, diasAno = 365, numero;

            Console.WriteLine("===========Medidor de Dias de Vida===========");
                Console.ReadKey();

                Console.WriteLine("Qual o seu nome? ");
                nome = Console.ReadLine();

                Console.WriteLine("Qual sua idade? ");
                valorDigitado = Console.ReadLine();

                //Verificacao
                numeroInteiro = double.TryParse(valorDigitado, out numero);

            if (numeroInteiro)
            {
                idade = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido! ");
                Console.ReadKey();
            }
            double diasVividos = 0;
            diasVividos = idade * diasAno;
            Console.WriteLine("Você viveu por " + diasVividos + " dias, " + nome + " .");
            Console.ReadLine();
        }
    }
}
