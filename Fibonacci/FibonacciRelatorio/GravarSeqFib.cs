using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.FibonacciRelatorio
{
    public class GravarSeqFib
    {
        public static void GravarFibonacci(List<int> listanumero, int numero)
        {

            string folderPath = @"C:\Test";
            if (Directory.Exists(folderPath) == false)
            {
                Directory.CreateDirectory(folderPath);

            }

            string txt = @$"C:\Test\Fibonacci.txt";

            StreamWriter sw;
            if (File.Exists(txt) == true)
            {

                sw = File.AppendText(txt);
            }
            else
            {
                sw = File.CreateText(txt);
                sw.WriteLine(new String('-', 60));
                sw.WriteLine($"*       Tabela de  Fibonacci *");
                sw.WriteLine(new String('-', 60));

            }

            int contar = listanumero.Count;
            sw.WriteLine(new String('-', 60));
            sw.WriteLine($"           SEQUENCIA FIBONACCI  ");
            sw.WriteLine("");
            sw.WriteLine($"       Entre O a {numero} temos {contar} numeros ");
            sw.WriteLine(new String('-', 60));
            foreach (var item in listanumero)
            {

                sw.WriteLine($"{item}");


            }
            sw.Close();

        }
    }
}
