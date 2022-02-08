using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mlado1, mlado2, numero;
            string opcao, valorDigitado;
            bool numeroInteiro;

            do
            {

                Console.WriteLine("======Medidor de Terreno========");

                Console.ReadKey();

                Console.WriteLine("Insira os metros do primeiro lado do retângulo: ");
                valorDigitado = Console.ReadLine();
                //Verificacao
                numeroInteiro = double.TryParse(valorDigitado, out numero);

                if (numeroInteiro)
                {
                    mlado1 = Math.Round(double.Parse(valorDigitado), 4);
                }
                else
                {
                    Console.Write("Digite um número válido! ");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Insira os metros do segundo lado do retângulo: ");
                valorDigitado = Console.ReadLine();
                //Verificacao
                numeroInteiro = double.TryParse(valorDigitado, out numero);

                if (numeroInteiro)
                {
                    mlado2 = Math.Round(double.Parse(valorDigitado), 4);
                }
                else
                {
                    Console.Write("Digite um número válido! ");
                    Console.ReadKey();
                    break;
                }

                double resultadoOperacao = 0;

                resultadoOperacao = mlado1 * mlado2;

                if (mlado1 == mlado2)
                {
                    Console.Write("O terreno precisa ser um retângulo ");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Seu terreno possui " + resultadoOperacao + "m² de profundidade. ");

                Console.WriteLine("Digite s para sair, ou r para repetir");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;


            } while (opcao == "r");

        }
    }
}
