using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conta de divisão");

            Console.WriteLine("Digite um numero para ser dividido");
            int valor01=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int valor02 =Convert.ToInt32(Console.ReadLine());

            int resultado = valor01 / valor02;

            Console.WriteLine("O resultado da sua divisão é: \n " + resultado);


        }
    }
}
