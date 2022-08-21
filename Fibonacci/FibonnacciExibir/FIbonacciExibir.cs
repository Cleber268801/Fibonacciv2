using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonnacciExibir
{
    public class FibonacciExibir
    {
        public static void ExibirFibonacci(List<int> fibona, int numero)

        {
            int contar = fibona.Count;
            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
            Console.WriteLine("");
            Console.WriteLine($"       Entre O a {numero} temos {contar} numeros ");
            Console.WriteLine(new String('-', 60));
            foreach (var item in fibona)
            {

                Console.WriteLine(item);


            }

            Console.ReadKey();
            FibonacciMenus.MenuOpcoes.Opcoes();

            
           
            
                   
        }

        
    }
}                                                                                                                                                                                          
