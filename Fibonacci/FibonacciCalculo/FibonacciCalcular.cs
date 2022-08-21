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
              
        public static  List<int>  SomarFibonacci(int numero)
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
            bool numeroExiste;
            numeroExiste = fibonacci.Contains(numero);         

            var listfibona =new List<Fibonacci1>();            
            listfibona.Add(new Fibonacci1(fibonacci,numero,numeroExiste));


            FibonnacciExibir.FibonacciExibir.ExibirFibonacci(fibonacci, numero);            
            FibonacciRelatorio.GravarSeqFib.GravarFibonacci(fibonacci, numero);
            return fibonacci;
    
        }


      
    }
    
}
