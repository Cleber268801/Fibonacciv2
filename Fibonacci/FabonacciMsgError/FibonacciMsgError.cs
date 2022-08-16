using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FabonacciMsgError
{
    public class FibonacciMsgError
    {
        public static void MsgError(string message)
        {

            Console.WriteLine(new String('-', 50));
            Console.WriteLine("       Caracteres invalidos ");
            Console.WriteLine("Sistema Aceita apenas Caracteres Numericos ");
            Console.WriteLine("       Aperte Enter e tente novamente ");
            Console.WriteLine(new String('-', 50));
            

        }
    }

    
}
