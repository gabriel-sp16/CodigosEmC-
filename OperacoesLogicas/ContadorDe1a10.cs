using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class ContadorDe1a10
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Esse algoritimo ira exibir 1 a 10");

            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }while (i < 11);
        }

    }
}
