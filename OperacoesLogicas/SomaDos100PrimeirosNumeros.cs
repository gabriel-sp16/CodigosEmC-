using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class SomaDos100PrimeirosNumeros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos 100 primeiros numeros inteiros");
            int i = 1 ,totalSoma = 0 ;
            while (i < 101) { 
            
            totalSoma += i ;
                i++;
            }
            Console.WriteLine("totaç da soma dos 100 primeiros numeros é " + totalSoma);
        }
    }
}
