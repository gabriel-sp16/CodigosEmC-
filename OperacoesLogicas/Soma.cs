using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class Soma
    {
      public static void Main (string[] args)




        {
            Console.WriteLine("Digite o valor solicitado: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            int soma =num1 + num2;

            Console.WriteLine("O valor somado é: " + soma);

        }
    }
}
