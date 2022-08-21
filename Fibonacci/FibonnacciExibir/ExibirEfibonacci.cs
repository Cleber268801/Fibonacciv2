using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonnacciExibir
{
    public class ExibirEfibonacci
    {
        public static void ExibirFibonacci(List<Fibonacci1> listfibona, int numero)

        {
          
            

            bool resposta;
            foreach (Fibonacci1 fibo in listfibona)
            {
                resposta = fibo.Efibonacci;
                if (resposta == true)
                {
                    Console.WriteLine(new String('-', 60));
                    Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
                    Console.WriteLine("");
                    Console.WriteLine($"       O Numero {numero} É Fibonacci ");
                    Console.WriteLine(new String('-', 60));
                    Console.ReadKey();

                    FibonacciMenus.MenuOpcoes.Opcoes();

                }

                else
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
    }
}

