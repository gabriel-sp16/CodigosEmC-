using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class Multipliucacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Algoritimo para fazer multiplicação \n");

            Console.WriteLine("Digite o primeiro valor que ira ser multiplicado");

            int numero01=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor ");

            int numero02 =Convert.ToInt32(Console.ReadLine());

            int resultado=numero02 * numero01;

            Console.WriteLine("O valor da sua Multíplicação é:\n" + resultado);
        }
    }
}
