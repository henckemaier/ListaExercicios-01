using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("===========Transformador de Celcius para Fahrenheit===========");
            Console.ReadKey();

            Console.Write("Insira sua temperatura em celcius: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = c * 1.8 + 32;

            Console.WriteLine("Celcius para fahrenheit vira: " + f + " fahrenheits");
            Console.ReadKey();
        }
    }
}
