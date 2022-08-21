using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonacciMenus
{
    public class MenuFibonacci
    {


        public static void  SeqFibonacci()

       {
            Console.Clear();
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"              SEQUENCIA FIBONACCI  ");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("*         Imprima uma Seuquencia Fibonacci       *");
            Console.WriteLine("*                                                *");
            Console.WriteLine("*              Digite um numero                  *");
            Console.WriteLine("*                                                *");
            Console.WriteLine(new String('-', 50));
            try
            {

                int numeroFibonacci = int.Parse(Console.ReadLine());
                FibonacciCalcular.FibonacciCalcular.SomarFibonacci(numeroFibonacci);
            }
            catch (Exception ex)
            {
                FabonacciMsgError.FibonacciMsgError.MsgError(ex.Message);
                
            }
       



        }

      

        public static void EFibonnaci()
        {
            Console.Clear();
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"              SEQUENCIA FIBONACCI  ");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("*         Descubra se o numero é Fibonacci       *");
            Console.WriteLine("*                                                *");
            Console.WriteLine("*              Digite um numero                  *");
            Console.WriteLine("*                                                *");
            Console.WriteLine(new String('-', 50));

            try
            {

                int numeroFibonacci = int.Parse(Console.ReadLine());
                FibonacciCalcular.EFibonacci.VerificarFibonacci(numeroFibonacci);

            }
            catch (Exception ex)
            {
                FabonacciMsgError.FibonacciMsgError.MsgError(ex.Message);

            }
        }

    }
}
