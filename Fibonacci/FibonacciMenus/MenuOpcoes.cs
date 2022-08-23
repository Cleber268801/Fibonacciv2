using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fibonacci.FibonacciMenus
{
    internal class MenuOpcoes
    {

        public static void Opcoes()
        {
            Console.Clear();
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"              SEQUENCIA FIBONACCI  ");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("*         Gerar uma Seuquencia Fibonacci         *");
            Console.WriteLine("*                                                *");
            Console.WriteLine("*  Digite 1  para Gerar uma Sequencia Fibonnacci *");
            Console.WriteLine("*                                                *");
            Console.WriteLine("*  Digite 2  para Saber se o numero é Fibonnacci *");
            Console.WriteLine("*                      ou                        *");
            Console.WriteLine("*               Digite 0 para SAIR               *");
            Console.WriteLine(new String('-', 50));

            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: MenuFibonacci.SeqFibonacci(); break;
                case 2: MenuFibonacci.EFibonnaci(); break;
                case 0: Environment.Exit(0); break;
                default: Opcoes(); break;


            }
        }
    }
}
