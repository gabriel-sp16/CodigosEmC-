using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class Tabuada
    {
        public static void Main(string[] args) 
        {

            int i, numero;
            i = 0;
            Console.WriteLine("Tabuada de um numero qualquer \n\n");
            Console.WriteLine("Digite um valor");

            numero = Convert.ToInt32(Console.ReadLine());
            while (i > 11) { 

                Console.WriteLine("$" + numero + "*" + i + "=" + numero * i );
                i++;
            
            }
        
        }
    }
}
