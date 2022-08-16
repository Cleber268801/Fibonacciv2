using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonnacciExibir
{
    public class ExibirEfibonacci
    {
        public static void ExibirFibonacci(List<int> listanumero, int numero)

        {
            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
            Console.WriteLine("");
            Console.WriteLine($"       O Numero {numero} É Fibonacci ");
            Console.WriteLine(new String('-', 60));
            Console.ReadKey();
            FibonacciMenus.MenuOpcoes.Opcoes();


        }
    }
    public class ExibirNaoEfibonacci
    {
        public static void ExibirNaoFibonacci(List<int> listanumero, int numero)

        {
           

            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
            Console.WriteLine("");
            Console.WriteLine($"       O Numero {numero} Não É Fibonacci ");
            Console.WriteLine(new String('-', 60));
            Console.ReadKey();
            FibonacciMenus.MenuOpcoes.Opcoes();

        }
    }
}

