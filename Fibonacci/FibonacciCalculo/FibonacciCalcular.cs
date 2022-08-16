using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonacciCalcular
{
    public class FibonacciCalcular
    {
        
        public static List<int> SomarFibonacci(int numero)
        {
            List<int> fibonacci = new List<int>();         
                Console.Clear();
                int soma = 0;
                int fib = 1;
               
                fibonacci.Add(soma);
                fibonacci.Add(fib);
            while (soma < numero)
            {
                soma += fib;
                fib += soma;
                if (soma <= numero)
                {
                    fibonacci.Add(soma);

                }
                if (fib <= numero)
                {
                    fibonacci.Add(fib);
                }

            }
            FibonnacciExibir.FIbonacciExibir.ExibirFibonacci(fibonacci,numero);
            FibonacciRelatorio.GravarSeqFib.GravarFibonacci(fibonacci, numero);
            return fibonacci;



        }
    }
}
