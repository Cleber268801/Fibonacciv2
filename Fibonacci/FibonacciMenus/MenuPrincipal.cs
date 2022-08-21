using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonacciMenus
{
    public class MenuPrincipal
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"              SEQUENCIA FIBONACCI  ");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("*         Gerar uma Seuquencia Fibonacci         *");
            Console.WriteLine("*                                                *");
            Console.WriteLine("*               Digite 1  para ENTRAR            *");
            Console.WriteLine("*                      ou                        *");
            Console.WriteLine("*               Digite 0 para SAIR               *");
            Console.WriteLine(new String('-', 50));

            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1: MenuOpcoes.Opcoes();; break;
                case 0: Environment.Exit(0); break;
               


            }
        }
    }
}
