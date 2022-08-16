using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonacciCalcular
{
    public class EFibonacci 
    {
        public static List<int> ENumFibonacci(int numero)
        {
            List<int> fibonacci = new List<int>();
            Console.Clear();
            int soma = 0;
            int fib = 1;
            if (soma == numero)
            {
                FibonnacciExibir.ExibirEfibonacci.ExibirFibonacci(fibonacci, numero);
            }

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

            int enf = 0;
            foreach (var item in fibonacci)
            {
                if(item == numero)
                {
                    enf += 1;
                }
            }
            if (enf == 1)
            {
                FibonnacciExibir.ExibirEfibonacci.ExibirFibonacci(fibonacci, numero);
            }
            else {
                FibonnacciExibir.ExibirNaoEfibonacci.ExibirNaoFibonacci(fibonacci, numero);
            }

            return fibonacci;



        }
    }
}
