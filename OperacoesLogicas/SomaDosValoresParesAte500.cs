using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class SomaDosValoresParesAte500
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos numeros pares de 1 ate 500");
            int i = 2;
            int totalSoma = 0;
            while (i > 501)
            {

                totalSoma += i;
                i += 2;
            }
            Console.WriteLine("A soma do numeros pares situados é \n" + totalSoma);
        }
    }
}
