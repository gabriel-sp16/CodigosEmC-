using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class Subtracao
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Digite o valor a ser subtraido: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor a ser subtraido: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            int subtracao = num1 - num2;

            Console.WriteLine("O resultado da subtração é: " + subtracao);
        }
    }
}
