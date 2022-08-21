using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonacciCalcular
{
     public class EFibonacci 
     {
         public static  List<int>  VerificarFibonacci(int numero)
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
            Console.Clear();
            FibonnacciExibir.ExibirEfibonacci.ExibirFibonacci(listfibona, numero);

         return fibonacci;

         }
     }
}
