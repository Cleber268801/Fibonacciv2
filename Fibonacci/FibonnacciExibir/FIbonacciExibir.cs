using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonnacciExibir
{
    public class FibonacciExibir
    {
        public static void ExibirFibonacci( int numeroDigitatdo)

        {

            Fibonacci1 fibonacciLista = FibonacciCalcular.FibonacciCalcular.Fibonacci(numeroDigitatdo);
            int contar = fibonacciLista.ListaFibonacci.Count;

            Console.Clear();
            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
            Console.WriteLine("");
            Console.WriteLine($"       Entre O a {numeroDigitatdo} temos {contar} numeros ");
            Console.WriteLine(new String('-', 60));

            foreach (var item in fibonacciLista.ListaFibonacci)
            {

                Console.WriteLine(item);
                
                

            }

            Console.ReadKey();
            FibonacciMenus.MenuOpcoes.Opcoes();

            
           
            
                   
        }

        
    }
}                                                                                                                                                                                          
