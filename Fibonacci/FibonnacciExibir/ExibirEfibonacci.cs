using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonnacciExibir
{
    public class ExibirEfibonacci
    {
        public static void ExibirFibonacci(int numeroDigitatdo)

        {

            Console.Clear();
            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
            Console.WriteLine("");
            Console.WriteLine($"       O Numero {numeroDigitatdo} É Fibonacci ");
            Console.WriteLine(new String('-', 60));
            Console.ReadKey();

            FibonacciMenus.MenuOpcoes.Opcoes();

        }
        public static void ExibirNaoFibonacci(int numeroDigitatdo)

        {
            Console.Clear();
            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
            Console.WriteLine("");
            Console.WriteLine($"       O Numero {numeroDigitatdo} Não É Fibonacci ");
            Console.WriteLine(new String('-', 60));
            Console.ReadKey();
            FibonacciMenus.MenuOpcoes.Opcoes();

        }
    }
}

