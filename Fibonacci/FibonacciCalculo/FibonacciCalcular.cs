using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci;

namespace Fibonacci.FibonacciCalcular
{
    public class FibonacciCalcular
    {
              
        public static Fibonacci1 Fibonacci(int numero)
        {
            List<int> fibonacci = new List<int>();         
                
                int soma = 0;
                int fib = 1;
               
                fibonacci.Add(soma);
                
            while (soma < numero)
            {
                soma += fib;
                fib = soma-fib;
                if (soma <= numero)
                {
                    fibonacci.Add(soma);

                }
               
            }

            bool numeroExiste = fibonacci.Contains(numero);

            Fibonacci1 fibonacciObj = new Fibonacci1();

            fibonacciObj.ListaFibonacci = fibonacci;
            fibonacciObj.Efibonacci = numeroExiste;
            fibonacciObj.Numero = numero;

            return fibonacciObj;
    
        }


      
    }
    
}
